using Microsoft.IdentityModel.Tokens;
using RevJWTTokenAuthentication.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RevJWTTokenAuthentication.Repository
{
    public class JwtManagerRepository : IJwtManagerRepository
    {

        private readonly IConfiguration _configuration;
        private Dictionary<string, string> userrecords = new Dictionary<string, string>()
        {

            {"User1","Password1" },
            {"User2","Password2" },
            {"User3","Password3" },
        };
        public JwtManagerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Tokens authenticate(Users user)
        {
            if (!userrecords.Any(x => x.Key == user.UserName && x.Value == user.Password))
            {
                return null;
            }
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
            var tokendescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                   new Claim[] { new Claim(ClaimTypes.Name, user.UserName)

                   }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)

            };
            var token = tokenhandler.CreateToken(tokendescriptor);
            return new Tokens { Token = tokenhandler.WriteToken(token) };

        }
    }
}
