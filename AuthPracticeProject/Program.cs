using System.Text;
using AuthPracticeProject.Constants;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(options =>
	{
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Consts.SECRET_KEY)),
			ValidateIssuer = false,
			ValidateAudience = false,
			ValidateLifetime = true
		};
	});

builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("AdminOnly", policy =>
		policy.RequireRole("Admin"));
	options.AddPolicy("UsersOnly", policy =>
		policy.RequireRole("User")
			.RequireAssertion(context =>
			{
				var ageClaim = context.User.FindFirst("age");
				if (ageClaim != null && int.TryParse(ageClaim.Value, out int age))
				{
					return age > 18;
				}
				return false;
			}));
});
builder.Services.AddAuthorization();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.UseAuthentication();
app.UseAuthorization();


app.Run();