using NB.Analytics.DomainShared;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace NB.Analytics.Domain
{
    [DependsOn(
          typeof(NBAnalyticsDomainSharedModule)
        )]
    public class NBAnalyticsDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}
