using AutoMapper;
using MotelManagement.Customers.Dto;
using MotelManagement.Entites;

namespace MotelManagement.Customers
{
    public class CustomerAutoMapper : Profile
    {
        public CustomerAutoMapper()
        {
            CreateMap<Customer, CustomerDto>(MemberList.None);
            CreateMap<CustomerDto, Customer>(MemberList.None);
            CreateMap<Customer, GetCustomerDto>(MemberList.None);
            CreateMap<Customer, GetCustomerForEditDto>(MemberList.None);
            CreateMap<CreateUpdateCustomerDto, Customer>(MemberList.None);
        }
    }
}
