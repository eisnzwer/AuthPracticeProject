namespace AuthPracticeProject.Models;

public class User
{
	public int Id { get; set; }
	public int? Age { get; set; }
	public string? Login { get; set; }
	public string? Password { get; set; }
	public Roles Roles { get; set; }

	public User()
	{
	}

	public User(int id, int? age, string? login, string? password, Roles roles)
	{
		Id = id;
		Age = age;
		Login = login;
		Password = password;
		Roles = roles;
	}
}