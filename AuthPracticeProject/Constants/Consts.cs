using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace AuthPracticeProject.Constants;

public static class Consts
{
	public static string TOKEN = "123123123"; 
	public static string SECRET_KEY = "secretttttttttttttttttttttttttttttttttttttttttttttttttttt"; 
	public static readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));
}