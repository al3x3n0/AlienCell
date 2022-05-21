using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MessagePack;
using MessagePipe;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using MicroOrm.Dapper.Repositories.SqlGenerator;

using AlienCell.Server.Auth;
using AlienCell.Server.Cache;
using AlienCell.Server.Db;
using AlienCell.Server.Repositories;
using AlienCell.Server.Services;


namespace AlienCell.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();

            services.AddMagicOnion(options =>
            {
                options.EnableCurrentContext = true;
            });

            services.AddMessagePipe();
            
            services.AddEasyCaching(opt =>
            {
                opt.UseRedis(Configuration, "redis");
                opt.WithMessagePack(x => 
                {
                    x.EnableCustomResolver = true; 
                    x.CustomResolvers = MessagePack.Resolvers.CompositeResolver.Create(new MessagePack.IFormatterResolver[]
                    {
                        Cysharp.Serialization.MessagePack.UlidMessagePackResolver.Instance,
                        MessagePack.Resolvers.StandardResolver.Instance
                    });
                }, "msgpack");
            });

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSingleton<ChallengeService>();
            services.Configure<ChallengeServiceOptions>(Configuration.GetSection("AlienCell.Server.Auth:ChallengeService"));

            services.AddSingleton<JwtTokenService>();
            services.Configure<JwtTokenServiceOptions>(Configuration.GetSection("AlienCell.Server.Auth:JwtTokenService"));

            services.Configure<DbConnectionOptions>(Configuration.GetSection("AlienCell.Server.DB"));
            services.AddSingleton<IDbContext, DbContext>();

            services.Configure<UserCacheOptions>(Configuration.GetSection("AlienCell.Server.Cache:UserCache"));
            services.AddSingleton<UserCache>();
            
            services.AddScoped<IDbChangeSet, DbChangeSet>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ICurrentUserService, CurrentUserService>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(Configuration.GetSection("AlienCell.Server.Auth:JwtTokenService:Secret").Value)),
                        RequireExpirationTime = true,
                        RequireSignedTokens = true,
                        ClockSkew = TimeSpan.FromSeconds(10),

                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                    };
#if DEBUG
                    options.RequireHttpsMetadata = false;
#endif
                });
            services.AddAuthorization();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //
            //JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            //{
            //    Converters = new List<JsonConverter> { new UlidConverter() }
            //};
            //
            //
            var msgPackResolver = MessagePack.Resolvers.CompositeResolver.Create(
                Cysharp.Serialization.MessagePack.UlidMessagePackResolver.Instance,
                MessagePack.Resolvers.StandardResolver.Instance);
            //
            var msgPackOptions = MessagePackSerializerOptions.Standard
                .WithResolver(msgPackResolver);
            //
            MessagePackSerializer.DefaultOptions = msgPackOptions;
            //
            Dapper.SqlMapper.AddTypeHandler(new BinaryUlidHandler());
            //
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapMagicOnionService();
            });
        }
    }
}

