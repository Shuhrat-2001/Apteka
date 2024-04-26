using AutoMapper;
using Contract.Requests.MedicationRequests;
using Contract.Responses;
using Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Common.Mapping
{
    public class MedicationMapProfile : Profile
    {
        public MedicationMapProfile()
        {
            CreateMap<CreateMedicationRequests, Medication>();
            CreateMap<Medication, SingleMedicationResponses>();
        }
    }
}
