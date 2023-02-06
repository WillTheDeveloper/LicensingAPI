namespace DapperAPI.Models;

public class License
{
    public int Id { get; set; }
    public string LicenseKey { get; set; } = null!;
    public int UserId { get; set; }
    public DateTime Expiry { get; set; }
}