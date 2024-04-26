using AutoMapper;
using Contract.Requests.ManufacturerRequests;
using Contracts.Responses;
using Domain.Entities;

namespace Application.Common.Mapping
{
    public class ManufacturerMapProfile : Profile
    {
        public ManufacturerMapProfile()
        {
            CreateMap<CreateManufacturerRequests, Manufacturer>();
            CreateMap<Manufacturer, SingleManufacturerResponses>();
        }
    }
}
