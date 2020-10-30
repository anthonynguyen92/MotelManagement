using AutoMapper;
using MotelManagement.Motels.Dto;
using MotelManagement.Entites;

namespace MotelManagement.Motels
{
    public class MotelAutoMapper : Profile
    {
        public MotelAutoMapper()
        {
            CreateMap<Motel, MotelDto>(MemberList.None);
            CreateMap<MotelDto, Motel>(MemberList.None);
            CreateMap<Motel, GetMotelDto>(MemberList.None);
            CreateMap<Motel, GetMotelForEditDto>(MemberList.None);
            CreateMap<CreateUpdateMotelDto, Motel>(MemberList.None);
        }
    }
}
