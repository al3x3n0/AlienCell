//
using MicroOrm.Dapper.Repositories;
using MicroOrm.Dapper.Repositories.DbContext;

using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Db
{

public partial interface IDbContext : IDapperDbContext
{
    IDapperRepository<AccountModel> Accounts { get; }
}

}
