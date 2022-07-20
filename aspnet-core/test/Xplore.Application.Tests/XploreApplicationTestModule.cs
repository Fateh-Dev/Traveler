using Volo.Abp.Modularity;

namespace Xplore;

[DependsOn(
    typeof(XploreApplicationModule),
    typeof(XploreDomainTestModule)
    )]
public class XploreApplicationTestModule : AbpModule
{

}
