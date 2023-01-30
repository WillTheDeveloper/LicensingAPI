using LearningThisToday.ServiceLayer;

namespace LearningThisToday;

public static class Endpoints
{
	public static void MapEndpoints(this WebApplication app)
	{
		app.MapGet("/hello", TestMethod);
		app.MapGet("/world", TestMethod2);
	}

	public static string TestMethod(IWhateverService service)
	{
		return service.TestMethod();
	}

	public static IResult TestMethod2(IWhateverService service)
	{
		return Results.Ok(service.TestMethod2());
	}
}
