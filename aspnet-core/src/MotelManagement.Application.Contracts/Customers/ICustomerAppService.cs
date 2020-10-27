using MotelManagement.Customers.Dto;
using System;

namespace MotelManagement.Customers
{
    public interface ICustomerAppService : IBaseAppService<
        Guid, CreateUpdateCustomerDto, GetCustomerDto, GetCustomerForEditDto, GetCustomerForInputDto>
    {
    }
}
