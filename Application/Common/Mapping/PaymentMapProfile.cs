using AutoMapper;
using Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Common.Mapping
{
    public class PaymentMapProfile : Profile
    {
        public PaymentMapProfile()
        {
            CreateMap<CreatePaymentRequest, Payment>();
            CreateMap<Payment, SinglePaymentResponse>();
        }
    }
}
