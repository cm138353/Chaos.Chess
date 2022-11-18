using System.Threading.Tasks;

namespace Chaos.Chess.Data;

public interface IChessDbSchemaMigrator
{
    Task MigrateAsync();
}
