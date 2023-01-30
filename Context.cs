using System.Data;
using System.Data.SqlClient;

namespace DapperAPI;

public class Context
{
	private readonly IConfiguration _configuration;
	private readonly string _connectionString;

	public Context(IConfiguration configuration)
	{
		_configuration = configuration;

		_connectionString = _configuration.GetConnectionString("Database");
	}

	public IDbConnection NewDBConnection()
	{
		return new SqlConnection(_connectionString);
	}

}
