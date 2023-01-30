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
		public string GetUser(int id)
		{
			var data = _whateverData.GetUser(id);

			return data.FirstName;
		}
	}
}
