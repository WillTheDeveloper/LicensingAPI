using DapperAPI.DataLayer;
using DapperAPI.Models;

namespace DapperAPI.ServiceLayer
{
	public class WhateverService : IWhateverService
	{
		readonly IWhateverData _whateverData;

		public WhateverService(IWhateverData data)
		{
			_whateverData = data;
		}
		
		/*public string TestMethod()
		{
			return _whateverData.TestMethod();
		}

		public IEnumerable<User> TestMethod2()
		{
			return _whateverData.TestMethod2();
		}*/
		public User GetUser(int id)
		{
			return _whateverData.GetUser(id);
		}

		public IEnumerable<User> GetAllUsers()
		{
			return _whateverData.GetAllUsers();
		}
	}
}
