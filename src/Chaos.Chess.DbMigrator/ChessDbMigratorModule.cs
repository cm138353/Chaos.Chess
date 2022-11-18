using Chaos.Chess.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Chaos.Chess.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ChessEntityFrameworkCoreModule),
    typeof(ChessApplicationContractsModule)
    )]
public class ChessDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
