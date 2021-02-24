using AutoMapper;
using IdealDesign_Domain.Models;
using IdealDesign_WebModels.VewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_Services.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductVM>()               
                .ReverseMap()
                .ForMember(dest => dest.ProductOrders, src => src.Ignore());

            CreateMap<Career, CareerVM>()
                .ForMember(dest => dest.Resume, src => src.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Resume, src => src.Ignore());
        }
    }
}
