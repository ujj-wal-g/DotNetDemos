using JWTAuthentication.Model;


namespace JWTAuthenticationDemo2.IServices
{
    public interface IUserInfoServices
    {
        UserInfo Authenticate(string username, string password);
    }
}
