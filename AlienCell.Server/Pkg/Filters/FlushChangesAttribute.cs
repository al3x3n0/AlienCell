using MagicOnion;
using MagicOnion.Server;

using AlienCell.Server.DB;


namespace AlienCell.Server.Filters
{

public class FlushChangesAttribute : MagicOnionFilterAttribute
{
    private readonly DbContext _db;

    public FlushChangesAttribute(DbContext db)
    {
        this._db = db;
    }

    public override async ValueTask Invoke(ServiceContext context, Func<ServiceContext, ValueTask> next)
    {
        try
        {
            var dbChangeSet = new DbChangeSet();
            context.Items[nameof(DbChangeSet)] = dbChangeSet;
            await next(context);
            Console.WriteLine("Flushing changes to db...");
            await dbChangeSet.FlushChanges(this._db);
        }
        catch
        {
            /* on exception */
            throw;
        }
        finally
        {
            /* on finally */
        }
    }
}

}

