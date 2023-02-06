using DapperAPI.DataLayer;
using DapperAPI.Models;

namespace DapperAPI.ServiceLayer
{
	public class WhateverService : IWhateverService
	{
		readonly IWhateverData _whateverData;
		private IWhateverService _whateverServiceImplementation;

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

		public IEnumerable<License> GetAllUserLicenses(int id)
		{
			return _whateverData.GetAllUserLicenses(id);
		}

		public IEnumerable<License> GetAllLicenses()
		{
			return _whateverData.GetAllLicenses();
		}

		public User CreateNewUser(string firstName, string secondName)
		{
			return _whateverData.CreateNewUser(firstName, secondName);
		}

		public License CreateNewLicense(string licenseKey, int userId, DateOnly expiry)
		{
			return _whateverData.CreateNewLicense(licenseKey, userId, expiry);
		}
	}
}
