using Dapper;
using LearningThisToday.Models;

namespace LearningThisToday.DataLayer;

public class WhateverData : IWhateverData
{
	readonly Context _context;

	public WhateverData(Context context)
	{
		_context = context;
	}

	public string TestMethod()
	{
		using(var connection = _context.NewDBConnection())
		{
			var data = connection.Query<User>("SELECT id, firstname, lastname FROM Users").ToList();

			var datastring = "";

			data.ForEach(x => datastring += x.firstname);

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
	}
}
