using JWTAuthenticationDemo2.Helpers;
using JWTAuthenticationDemo2.IServices;
using JWTAuthentication.Model;

using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace JWTAuthentication.Services
{
    public class UserInfoServices : IUserInfoServices
    {
        private List<UserInfo> _users = new List<UserInfo>
        {
            new UserInfo{UserInfoId = Guid.NewGuid(),FullName="Ujjwal Goyal",EmailId="abcd@gmail.com",UserName="Ujjwal@123",Password="CodeStore"}
        };
        private readonly AppSetting _appSetting;
        public UserInfoServices(IOptions<AppSetting> appSetting)
        {
            _appSetting = appSetting.Value;
        }
        public UserInfo Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.UserName == username && x.Password == password);
            if (user == null) return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var Key = Encoding.ASCII.GetBytes(_appSetting.Secret);
            var tokenDescripter = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,user.UserInfoId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature)


            };
            var token = tokenHandler.CreateToken(tokenDescripter);
            user.Token = tokenHandler.WriteToken(token);

            return user;
        }
        public IEnumerable<UserInfo> GetAll()
        {
            return _users;
        }

    }
}
