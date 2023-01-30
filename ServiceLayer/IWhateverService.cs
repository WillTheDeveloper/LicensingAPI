using DapperAPI.Models;

namespace DapperAPI.ServiceLayer;

public interface IWhateverService
{
	/*public string TestMethod();
	public IEnumerable<User> TestMethod2();*/
	string GetUser(int id);
}
