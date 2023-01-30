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
