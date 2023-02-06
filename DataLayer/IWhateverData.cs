using DapperAPI.Models;

namespace DapperAPI.DataLayer;

public interface IWhateverData
{
	public User GetUser(int id);
	public IEnumerable<User> GetAllUsers();
	public IEnumerable<License> GetAllUserLicenses(int id);
	public IEnumerable<License> GetAllLicenses();
	public User CreateNewUser(string firstName, string secondName);
	public License CreateNewLicense(string licenseKey, int userId, DateOnly expiry);
}
