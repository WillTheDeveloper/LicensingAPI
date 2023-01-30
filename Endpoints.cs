using DapperAPI.ServiceLayer;

namespace DapperAPI;

public static class Endpoints
{
	public static void MapEndpoints(this WebApplication app)
	{
		/*app.MapGet("/hello", TestMethod);
		app.MapGet("/world", TestMethod2);*/
		app.MapGet("/user/{id}", GetUser);
	}

	public static string GetUser(IWhateverService service, int id)
	{
		return service.GetUser(id);
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
