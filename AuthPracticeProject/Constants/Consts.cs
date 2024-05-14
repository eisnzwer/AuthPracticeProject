using System.Text;
using AuthPracticeProject.Models;
using Microsoft.IdentityModel.Tokens;

namespace AuthPracticeProject.Constants;

public static class Consts
{
	public static string SECRET_KEY = "secretttttttttttttttttttttttttttttttttttttttttttttttttttt"; 
	public static readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

	public static string ADMIN_TOKEN =
		"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJ1c2VyMTIzIiwicm9sZSI6IkFkbWluIiwiYWdlIjoyNSwiaWF0IjoxNTY2NjY2Njc4LCJleHAiOjE3NjY2NjY3Nzh9.361vD2hYvlqiRfhC64pThlyeGoMovZjmHrzBL-fk1kk";
	public static string USERS_TOKEN = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJ1c2VyMTIzNCIsInJvbGUiOiJVc2VyIiwiYWdlIjoxOSwiaWF0IjoxNTY2NjY2Njc4LCJleHAiOjE3NjY2NjY3Nzh9.idV4UkB5EFILiVbaWFaMocrVn4-aaMPeRFy2-gjwP6k";
	
}
