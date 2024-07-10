public static class IEndpointRouteBuilderExtensions
{
  // Extension method for IEndpointRouteBuilder
  public static void MapEndpoints(this IEndpointRouteBuilder app, Assembly assembly)
  {
    // Get the type of the interface IEndpointRouteHandler
    var endpointRouteHandlerInterfaceType = typeof(IEndpointRouteHandler);

    // Find all types in the provided assembly that match the criteria
    var endpointRouteHandlerTypes = assembly.GetTypes().Where(t =>
        t.IsClass &&                      // Must be a class
        !t.IsAbstract &&                  // Must not be abstract
        !t.IsGenericType &&               // Must not be a generic type
        t.GetConstructor(Type.EmptyTypes) != null && // Must have a parameterless constructor
        endpointRouteHandlerInterfaceType.IsAssignableFrom(t) // Must implement IEndpointRouteHandler
    );

    // Iterate through each found type
    foreach (var endpointRouteHandlerType in endpointRouteHandlerTypes)
    {
      // Create an instance of the type
      var instantiatedType = (IEndpointRouteHandler)Activator.CreateInstance(endpointRouteHandlerType)!;

      // Call the MapEndpoints method on the instantiated type, passing the IEndpointRouteBuilder instance
      instantiatedType.MapEndpoints(app);
    }
  }
}
