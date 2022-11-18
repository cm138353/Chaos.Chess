using Volo.Abp.Modularity;

namespace Chaos.Chess;

[DependsOn(
    typeof(ChessApplicationModule),
    typeof(ChessDomainTestModule)
    )]
public class ChessApplicationTestModule : AbpModule
{

}
