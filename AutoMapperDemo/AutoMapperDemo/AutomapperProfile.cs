using AutoMapper;

namespace AutoMapperDemo
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<StudentDto, Student>()
                .ForMember(dest1 => dest1.Age, opt => opt.MapFrom(s => s.CurrentAge))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(s => s.PersonalEmail));// If the properties of source are defferent from destination's
        }
    }
}
