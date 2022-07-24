using AutoMapper;
using Mobiliva.Entities.Concrete;
using Mobiliva.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Business.Automapper.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest=>dest.UpdateDate,opt=>opt.MapFrom(x=>DateTime.Now))
                .ForMember(dest=>dest.Status,opt=>opt.MapFrom(x=>true));
                
                
        }
    }
}
