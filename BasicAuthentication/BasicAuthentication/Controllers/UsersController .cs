using BasicAuthentication.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Web.Providers.Entities;

namespace BasicAuthentication.Controllers
{
    [Authorize]
    
    public class UsersController : ControllerBase
    {

        private readonly UserDBContext _dbContext;
       [HttpGet("Get")]
       public string Get()
        {
            //string username = HttpContext.User.Identity.Name;
            //var user = await _dbContext.userAuthentications
            //    .Where(UserAuthentication=>UserAuthentication.UserName==username)
            //    .FirstOrDefaultAsync();
            return "Successfully returned";
                
        }

    }
}
