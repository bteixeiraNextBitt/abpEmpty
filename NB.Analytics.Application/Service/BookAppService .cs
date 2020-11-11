using NB.Analytics.ApplicationContracts.Dto;
using NB.Analytics.ApplicationContracts.Service;
using NB.Analytics.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NB.Analytics.Application.Service
{
    public class BookAppService : NBAnalyticsService, IBookAppService
    {
        public Task CreateAsync(CreateUpdateBookDto input)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookDto>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
