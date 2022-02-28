using RevJWTTokenAuthentication.Model;

namespace RevJWTTokenAuthentication.Repository
{
    public interface IJwtManagerRepository
    {
        Tokens authenticate(Users user);
       
    }
}
