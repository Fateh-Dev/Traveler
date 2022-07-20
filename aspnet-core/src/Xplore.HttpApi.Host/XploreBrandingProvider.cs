using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Xplore;

[Dependency(ReplaceServices = true)]
public class XploreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Xplore";
}
