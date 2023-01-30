using LearningThisToday.Models;

namespace LearningThisToday.ServiceLayer;

public interface IWhateverService
{
	public string TestMethod();
	public IEnumerable<User> TestMethod2();
}
