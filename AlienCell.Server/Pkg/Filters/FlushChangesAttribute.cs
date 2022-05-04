using System.Data;
using MagicOnion;
using MagicOnion.Server;

using AlienCell.Server.Cache;
using AlienCell.Server.DB;


namespace AlienCell.Server.Filters
{

public class FlushChangesAttribute : MagicOnionFilterAttribute
{
    private readonly DbContext _db;
    private readonly UserCache _userCache;

    public FlushChangesAttribute(DbContext db, UserCache userCache)
    {
        this._db = db;
        this._userCache = userCache;
    }

    public override async ValueTask Invoke(ServiceContext context, Func<ServiceContext, ValueTask> next)
    {
        IDbTransaction tx = null;
        try
        {
            tx = this._db.BeginTransaction();
            context.Items["tx"] = tx;
            var changeSet = new DbChangeSet();
            context.Items[nameof(DbChangeSet)] = changeSet;
            await next(context);
            await changeSet.FlushDbChanges(this._db);
            await changeSet.FlushCache(this._userCache);
            tx?.Commit();
        }
        catch
        {
            tx?.Rollback();
            throw;
        }
        finally
        {
        }
    }
}

}

