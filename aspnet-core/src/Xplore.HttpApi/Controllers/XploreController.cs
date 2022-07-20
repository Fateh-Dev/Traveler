using Xplore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Xplore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class XploreController : AbpControllerBase
{
    protected XploreController()
    {
        LocalizationResource = typeof(XploreResource);
    }
}
