using AutoMapper;
using Financeasy.Business.Entities;

namespace Financeasy.Business.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, CustomerAddModel>().ReverseMap();
        }
    }
}