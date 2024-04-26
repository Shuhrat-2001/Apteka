﻿using AutoMapper;
using Contract.Requests.AuthorRequests;
using Contract.Responses;
using Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Common.Mapping
{
    public class ManufacturerMapProfile : Profile
    {
        public ManufacturerMapProfile()
        {
            CreateMap<CreateManufacturerRequest, Manufacturer>();
            CreateMap<Manufacturer, SingleManufacturerResponse>();
        }
    }
}
