using AutoMapper;
using NB.Analytics.ApplicationContracts.Dto;
using NB.Analytics.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Analytics.Application
{
    public class NBAnalyticsApplicationAutoMapperProfile : Profile
    {
        public NBAnalyticsApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
