//
using Microsoft.Extensions.Options;
using MicroOrm.Dapper.Repositories;
using MicroOrm.Dapper.Repositories.DbContext;
using MySql.Data.MySqlClient;


namespace AlienCell.Server.DB
{

public partial class DbContext : DapperDbContext, IDbContext
{
    public DbContext(IOptions<DBConnectionOptions> dbConnOptions)
        : base(new MySqlConnection(dbConnOptions.Value.ConnectionString))
    {
        InitDB();
    }
}

}

