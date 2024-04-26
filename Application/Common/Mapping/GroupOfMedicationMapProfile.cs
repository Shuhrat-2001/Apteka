using AutoMapper;
using Contract.Requests.GroupOfMadicationRequests;
using Contracts.Responses;
using Domain.Entity;

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
