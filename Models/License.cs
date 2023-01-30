namespace DapperAPI.Models;

public class License
{
    public int Id { get; set; }
    public string LicenseKey { get; set; } = null!;
    public User UserId { get; set; } = null!;
    public DateTime Expiry { get; set; }
}