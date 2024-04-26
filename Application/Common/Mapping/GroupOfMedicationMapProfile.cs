using AutoMapper;
using Contract.Requests.AuthorRequests;
using Contract.Requests.GroupOfMadicationRequests;
using Contract.Responses;
using Contracts.Responses;
using Domain.Entities;
using Domain.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Common.Mapping
{
    public class GroupOfMedicationMapProfile : Profile
    {
        public GroupOfMedicationMapProfile()
        {
            CreateMap<CreateGroupOfMadicationRequests, GroupOfMedication>();
            CreateMap<GroupOfMedication, SingleGroupOfMedicationResponses>();
        }
    }
}
