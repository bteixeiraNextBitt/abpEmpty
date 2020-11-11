using NB.Analytics.ApplicationContracts.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NB.Analytics.ApplicationContracts.Service
{
    public interface IBookAppService : IApplicationService
    {
        Task CreateAsync(CreateUpdateBookDto input);
        Task<List<BookDto>> GetAsync();
    }
}
