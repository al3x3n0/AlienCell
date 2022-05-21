using System.Data;
using MagicOnion;
using MagicOnion.Server;

using AlienCell.Server.Repositories;


namespace AlienCell.Server.Filters
{

public class FlushChangesAttribute : MagicOnionFilterAttribute
{
    public override async ValueTask Invoke(
        ServiceContext context,
        Func<ServiceContext, ValueTask> next)
    {
        try
        {
            var userRepo = context.ServiceProvider.GetService<IUserRepository>();
            await next(context);
            Console.WriteLine("Flushing changes to db...");
            userRepo.CommitChanges();
        }
        catch
        {
            throw;
        }
        finally
        {
        }
    }
}

}

