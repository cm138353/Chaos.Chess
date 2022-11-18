using Chaos.Chess.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Chaos.Chess;

[DependsOn(
    typeof(ChessEntityFrameworkCoreTestModule)
    )]
public class ChessDomainTestModule : AbpModule
{

}
