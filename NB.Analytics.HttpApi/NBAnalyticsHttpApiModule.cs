using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using NB.Analytics.Localization;
using NB.Analytics.ApplicationContracts;

namespace NB.Analytics.HttpApi
{
    [DependsOn(
        typeof(NBAnalyticsApplicationContractsModule)
        )]
   public class NBAnalyticsHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<NBAnalyticsResource>()
                    .AddBaseTypes();
            });
        }
    }
}
