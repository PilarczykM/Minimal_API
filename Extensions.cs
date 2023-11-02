namespace MinimalApi;

public static class Extensions
{
    public static void AddEndpointDefinition(this IServiceCollection services, params Type[] scanMarker)
    {
        var endpointDesinitions = new List<IEndpointDefinition>();

        foreach (var marker in scanMarker)
        {
            endpointDesinitions
                .AddRange(marker.Assembly.ExportedTypes
                    .Where(x => typeof(IEndpointDefinition).IsAssignableFrom(x) && !x.IsAbstract)
                    .Select(Activator.CreateInstance)
                    .Cast<IEndpointDefinition>());

            foreach (var endpoint in endpointDesinitions)
            {
                endpoint.DefineServices(services);
            }

            services.AddSingleton(endpointDesinitions as IReadOnlyCollection<IEndpointDefinition>);
        }
    }

    public static void UseEndpointDefinitions(this WebApplication app)
    {
        var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpointDefinition>>();

        foreach (var definition in definitions)
        {
            definition.DefineEndpoints(app);
        }
    }
}
