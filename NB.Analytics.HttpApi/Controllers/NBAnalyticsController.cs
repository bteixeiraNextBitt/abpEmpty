using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using NB.Analytics.Localization;

namespace NB.Analytics.HttpApi.Controllers
{
    /* Inherit your controllers from this class.
 */
    public abstract class NBAnalyticsController : AbpController
    {
        protected NBAnalyticsController()
        {
            LocalizationResource = typeof(NBAnalyticsResource);
        }
    }
}
