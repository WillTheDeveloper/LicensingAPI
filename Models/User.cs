namespace DapperAPI.Models;

public class User
{
	public int Id { get; set; }
	public string FirstName { get; set; } = null!;
	public string SecondName { get; set; } = null!;
	public License[]? Licenses { get; set; }
}
