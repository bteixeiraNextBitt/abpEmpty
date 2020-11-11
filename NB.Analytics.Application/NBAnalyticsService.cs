using System;
using System.Collections.Generic;
using System.Text;
using NB.Analytics.Localization;
using Volo.Abp.Application.Services;

namespace NB.Analytics.Application
{
    public abstract class NBAnalyticsService : ApplicationService
    {
        public NBAnalyticsService()
        {
            LocalizationResource = typeof(NBAnalyticsResource);
        }
    }
}
