using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Chaos.Chess.Data;

/* This is used if database provider does't define
 * IChessDbSchemaMigrator implementation.
 */
public class NullChessDbSchemaMigrator : IChessDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
