namespace DapperAPI.Models;

public class User
{
	public int Id { get; }
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
}
