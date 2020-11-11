using NB.Analytics.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.Validation.Localization;

namespace NB.Analytics.DomainShared
{
    public class NBAnalyticsDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

            Configure<AbpLocalizationOptions>(options =>
            {                  
                options.Resources
                    .Add<NBAnalyticsResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/NBAnalytics");

                options.DefaultResourceType = typeof(NBAnalyticsResource);
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("NBAnalytics", typeof(NBAnalyticsResource));
            });
        }
    }
}
