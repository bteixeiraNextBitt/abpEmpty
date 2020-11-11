using NB.Analytics.DomainShared;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace NB.Analytics.ApplicationContracts
{
    [DependsOn(
         typeof(NBAnalyticsDomainSharedModule),
         typeof(AbpObjectExtendingModule)
         )]
    public class NBAnalyticsApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            NBAnalyticsDtoExtensions.Configure();
        }
    }
}
