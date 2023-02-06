using System.Data;
using Dapper;
using DapperAPI.Models;

namespace DapperAPI.DataLayer;

public class WhateverData : IWhateverData
{
	readonly Context _context;

	public WhateverData(Context context)
	{
		_context = context;
	}

	public User GetUser(int id)
	{
		using (var connection = _context.NewDBConnection())
		{
			var data = connection.Query<User>("SELECT * FROM Users WHERE id = " + id).First();

			return data;
		}
	}

	public IEnumerable<User> GetAllUsers()
	{
		using (var connection = _context.NewDBConnection())
		{
			var data = connection.Query<User>("SELECT * FROM Users").ToList();

			return data;
		}
	}

	public IEnumerable<License> GetAllUserLicenses(int id)
	{
		using (var connection = _context.NewDBConnection())
		{
			var data = connection.Query<License>("SELECT * FROM Licenses WHERE UserId =" + id).ToList();

			return data;
		}
	}

	public IEnumerable<License> GetAllLicenses()
	{
		using (var connection = _context.NewDBConnection())
		{
			var data = connection.Query<License>("SELECT * FROM Licenses").ToList();

			return data;
		}
	}

	public User CreateNewUser(string firstName, string secondName)
	{
		using (var connection = _context.NewDBConnection())
		{
			var newuser = connection.QuerySingle<User>("pUserCreate", new { firstName = firstName, secondName = secondName }, commandType: CommandType.StoredProcedure);
			
			return newuser;
		}
	}

	public License CreateNewLicense(string licenseKey, int userId, DateOnly expiry)
	{
		using (var connection = _context.NewDBConnection())
		{
			var newlicense = connection.QuerySingle<License>("pLicenseCreate");
			
			return newlicense;
		}
	}

	/*public User UpdateUser(string firstName, string secondName)
	{
		
	}*/
}
