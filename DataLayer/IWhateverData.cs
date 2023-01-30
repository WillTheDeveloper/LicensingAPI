using DapperAPI.Models;

namespace DapperAPI.DataLayer;

public interface IWhateverData
{
	/*public string TestMethod();
	public IEnumerable<User> TestMethod2();*/
	public User GetUser(int id);
}
