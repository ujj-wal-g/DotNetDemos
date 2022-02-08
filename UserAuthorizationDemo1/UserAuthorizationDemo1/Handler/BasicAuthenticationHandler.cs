using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using UserAuthorizationDemo1.Model;

namespace UserAuthorizationDemo1.Handler
{
    public class BasicAuthenticationHandler
    {
        public class BasicAuthentiCationHandler : AuthenticationHandler<AuthenticationSchemeOptions>


        {
            private readonly UserContext _context;
            public BasicAuthentiCationHandler(
                IOptionsMonitor<AuthenticationSchemeOptions> options,
                ILoggerFactory logger,
                UrlEncoder encoder,
                ISystemClock clock,
              UserContext context) :

                base(options, logger, encoder, clock)
            {
                _context = context;
            }
            protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
            {
                if (Request.Headers.ContainsKey("Authorization"))
                {
                    try
                    {

                        var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                        var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                        string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                        string username = credentials[0];
                        string password = credentials[1];
                        UserRecord user = _context.userRecords.Where(user => user.UserName == username && user.Password == password).FirstOrDefault();

                        if (user == null)
                        {
                            return AuthenticateResult.Fail("Invalid UserName or Password");
                        }
                        else
                        {
                            var claims = new[] { new Claim(ClaimTypes.Name, user.UserName) };
                            var identity = new ClaimsIdentity(claims, Scheme.Name);
                            var principal = new ClaimsPrincipal(identity);
                            var ticket = new AuthenticationTicket(principal, Scheme.Name);
                            Console.WriteLine("Success");
                            return AuthenticateResult.Success(ticket);
                        }

                    }
                    catch (Exception ex)
                    {
                        return AuthenticateResult.Fail("Error has occured");
                    }
                }
                else
                {
                    return AuthenticateResult.Fail("Authorization header was not found");
                }
                return AuthenticateResult.Fail("Need Implementation");
            }
        }    }
}
