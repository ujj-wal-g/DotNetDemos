using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RevJWTTokenAuthentication.Repository;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(
    options => {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
  }).AddJwtBearer(o=>
  {
      var securityKey = Encoding.UTF8.GetBytes(builder.Configuration["JWT:key"]);
      o.SaveToken = true;
      o.TokenValidationParameters = new TokenValidationParameters
      {
          ValidateIssuerSigningKey = true,
          ValidIssuer = builder.Configuration["JWT:Issuer"],
          ValidAudience = builder.Configuration["JWT:Audience"],
          IssuerSigningKey = new SymmetricSecurityKey(securityKey),
          ValidateIssuer = false,
          ValidateAudience = false,
          ValidateLifetime = true
          

      };
  });
builder.Services.AddSingleton<IJwtManagerRepository,JwtManagerRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
