public class PeopleHandler : IEndpointRouteHandler
{
    public static void MapEndpoints(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/people", GetList);
        app.MapGet("/api/people/{id:guid}", Get);
        app.MapPost("/api/people", Insert);
        app.MapPut("/api/people/{id:guid}", Update);
        app.MapDelete("/api/people/{id:guid}", Delete);
    }

    private static IResult GetList(PeopleService peopleService)
    { /* ... */ }
    private static IResult Get(Guid id, PeopleService
    peopleService)
    { /* ... */ }
    private static IResult Insert(Person person,
    PeopleService people)
    { /* ... */ }
    private static IResult Update(Guid id, Person
    person, PeopleService people)
    { /* ... */ }
    private static IResult Delete(Guid id) 
    { /* ... */ }
}