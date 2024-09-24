﻿using AutoMapper;
using PCMS.API.DTOS.GET;
using PCMS.API.DTOS.PATCH;
using PCMS.API.DTOS.POST;
using PCMS.API.Models;

namespace PCMS.API.Mappers
{
    public class CaseActionMappingProfile : Profile
    {
        public CaseActionMappingProfile()
        {
            CreateMap<POSTCaseAction, CaseAction>();
            CreateMap<CaseAction, GETCaseAction>();
            CreateMap<PATCHCaseAction, CaseAction>();
        }
    }
}
