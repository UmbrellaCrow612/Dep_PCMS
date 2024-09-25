﻿using AutoMapper;
using PCMS.API.Dtos.GET;
using PCMS.API.Dtos.PATCH;
using PCMS.API.Dtos.POST;
using PCMS.API.Models;

namespace PCMS.API.Mappers
{
    public class ChargeMappingProfile : Profile
    {
        public ChargeMappingProfile()
        {
            CreateMap<POSTCharge, Charge>();
            CreateMap<Charge, GETCharge>();
            CreateMap<PATCHCharge, Charge>();
        }
    }
}
