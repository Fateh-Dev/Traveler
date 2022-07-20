using System;
using System.Collections.Generic;
using System.Text;
using Xplore.Localization;
using Volo.Abp.Application.Services;

namespace Xplore;

/* Inherit your application services from this class.
 */
public abstract class XploreAppService : ApplicationService
{
    protected XploreAppService()
    {
        LocalizationResource = typeof(XploreResource);
    }
}
