using AutoMapper;
using Contract.Requests.Orderrequests;
using Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Contracts;
using Domain.Entity;
using Contracts.Responses;

namespace Application.Common.Mapping
{
    public class OrderMapProfile : Profile
    {
        public OrderMapProfile()
        {
            CreateMap<CreateOrderRequests, Order>();
            CreateMap<Order, SingleOrderResponse>();
        }
    }
}
