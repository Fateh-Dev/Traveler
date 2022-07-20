using Xplore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Xplore;

[DependsOn(
    typeof(XploreEntityFrameworkCoreTestModule)
    )]
public class XploreDomainTestModule : AbpModule
{

}
