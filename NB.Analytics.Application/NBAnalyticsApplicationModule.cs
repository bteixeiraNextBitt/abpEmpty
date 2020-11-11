using NB.Analytics.Domain;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace NB.Analytics.Application
{
    [DependsOn(
       typeof(NBAnalyticsDomainModule)
       )]
    public class NBAnalyticsApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<NBAnalyticsApplicationModule>();
            });
        }
    }
}
