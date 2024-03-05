using AutoMapper;
using NewsPlatform.Application.DTOs;
using NewsPlatform.Domains.Entities;

namespace WillsPlatform.Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<News, NewsDTO>();
        }
    }
}
