namespace DapperAPI.Models;

public class License
{
    public int Id { get; }
    public string LicenseKey { get; set; } = null!;
    public User UserId { get; set; } = null!;
    public DateOnly Expiry { get; set; }
}