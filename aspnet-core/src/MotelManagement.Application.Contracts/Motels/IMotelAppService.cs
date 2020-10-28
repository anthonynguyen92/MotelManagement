using MotelManagement.Motels.Dto;
using System;

namespace MotelManagement.Motels
{
    public interface IMotelsAppService : IBaseAppService<
        Guid, CreateUpdateMotelDto, GetMotelDto, GetMotelForEditDto, GetMotelForInputDto>
    {
    }
}
