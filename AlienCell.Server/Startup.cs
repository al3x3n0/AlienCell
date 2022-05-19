using System;
using System.Collections.Generic;
using System.Linq;
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
                opt.WithMessagePack("redis");
            });

            services.AddSingleton<ChallengeService>();
            services.Configure<ChallengeServiceOptions>(Configuration.GetSection("AlienCell.Server.Auth:ChallengeService"));

            services.AddSingleton<JwtTokenService>();
            services.Configure<JwtTokenServiceOptions>(Configuration.GetSection("AlienCell.Server.Auth:JwtTokenService"));

            services.Configure<DbConnectionOptions>(Configuration.GetSection("AlienCell.Server.DB"));
            services.AddSingleton<DbContext>();

            services.Configure<UserCacheOptions>(Configuration.GetSection("AlienCell.Server.Cache:UserCache"));
            services.AddSingleton<UserCache>();
            services.AddSingleton<UserRepository>();

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
            var msgPackResolver = MessagePack.Resolvers.CompositeResolver.Create(
                Cysharp.Serialization.MessagePack.UlidMessagePackResolver.Instance,
                MessagePack.Resolvers.StandardResolver.Instance);
            var msgPackoptions = MessagePackSerializerOptions.Standard
                .WithResolver(msgPackResolver);
            MessagePackSerializer.DefaultOptions = msgPackoptions;
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

