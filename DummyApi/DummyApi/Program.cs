using JWTAuthentication.Services;
using JWTAuthenticationDemo2.Helpers;
using JWTAuthenticationDemo2.IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();// Add services to the container.
builder.Services.AddRazorPages();
var appsettingSection = builder.Configuration.GetSection("AppSetting");
builder.Services.Configure<AppSetting>(appsettingSection);
builder.Services.AddControllers();


var appSetting = appsettingSection.Get<AppSetting>();
var key = Encoding.ASCII.GetBytes(appSetting.Secret);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ClockSkew = TimeSpan.FromMinutes(30),
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false,

        };
    });

builder.Services.AddTransient<IUserInfoServices, UserInfoServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
