using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;
        public StudentController(IMapper mapper)
        {
            _mapper= mapper;
        }
        [HttpGet]
        public Student Get()
        {
            StudentDto studentDto = new StudentDto()
            {
                Name = "Jay",
                CurrentAge = 20,
                PersonalEmail= "Jay123@gmail.com"
            };
            return _mapper.Map<Student>(studentDto);
        }
    }
}
