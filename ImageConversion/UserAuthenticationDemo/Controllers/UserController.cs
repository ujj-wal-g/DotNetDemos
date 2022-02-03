using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ImageConversion.Repository;

namespace ImageConversion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;

        public UserController(IImageRepository imageRepository )
        {
           _imageRepository = imageRepository;
        }
      [HttpGet]
      public string ImageURL()
        {
            var Result = _imageRepository.ImageUrl();
            return Result;
        }
    }
}
