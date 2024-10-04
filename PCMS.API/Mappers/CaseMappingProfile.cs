﻿using AutoMapper;
using PCMS.API.DTOS.GET;
using PCMS.API.DTOS.PATCH;
using PCMS.API.DTOS.POST;
using PCMS.API.Models;

namespace PCMS.API.Mappers
{
    public class CaseMappingProfile : Profile
    {
        public CaseMappingProfile()
        {
            CreateMap<CreateCaseDto, Case>();
            CreateMap<Case, CaseDto>();
            CreateMap<UpdateCaseDto, Case>();
        }
    }
}