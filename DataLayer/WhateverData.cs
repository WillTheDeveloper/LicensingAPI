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

	/*public string TestMethod()
	{
		using(var connection = _context.NewDBConnection())
		{
			var data = connection.Query<User>("SELECT id, firstname, lastname FROM Users").ToList();

			var datastring = "";

			data.ForEach(x => datastring += x.FirstName);

			return datastring;
		}
	}

	public IEnumerable<User> TestMethod2()
	{
		using( var connection = _context.NewDBConnection())
		{
			var data = connection.Query<User>("SELECT id, firstname, lastname FROM Users").ToList();

			return data;
		}
	}*/
}
