using Xplore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Xplore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(XploreEntityFrameworkCoreModule),
    typeof(XploreApplicationContractsModule)
    )]
public class XploreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
