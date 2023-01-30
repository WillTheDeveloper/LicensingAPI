using LearningThisToday.DataLayer;
using LearningThisToday.Models;

namespace LearningThisToday.ServiceLayer
{
	public class WhateverService : IWhateverService
	{
		readonly IWhateverData _whateverData;

		public WhateverService(IWhateverData data)
		{
			_whateverData = data;
		}
		
		public string TestMethod()
		{
			return _whateverData.TestMethod();
		}

		public IEnumerable<User> TestMethod2()
		{
			return _whateverData.TestMethod2();
		}
	}
}
