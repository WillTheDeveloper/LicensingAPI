using DapperAPI.ServiceLayer;

namespace DapperAPI;

public static class Endpoints
{
	public static void MapEndpoints(this WebApplication app)
	{
		/*app.MapGet("/hello", TestMethod);
		app.MapGet("/world", TestMethod2);*/
		app.MapGet("/user/{id}", GetUser);
		app.MapGet("/users", AllUsers);
	}

	private static IResult GetUser(IWhateverService service, int id)
	{
		return Results.Ok(service.GetUser(id));
	}

	private static IResult AllUsers(IWhateverService service)
	{
		return Results.Ok(service.GetAllUsers());
	}

	/*public static string TestMethod(IWhateverService service)
	{
		return service.TestMethod();
	}

	public static IResult TestMethod2(IWhateverService service)
	{
		return Results.Ok(service.TestMethod2());
	}*/
}
