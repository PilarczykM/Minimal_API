using MinimalApi.Abstractions;

namespace MinimalApi
{
    public static class Extensions
    {
        public static void AddEndpointDefinition(this IServiceCollection service, params Type[] scanMarker)
        {
            var endpointDesinitions = new List<IEndpointDefinition>();

            foreach (var marker in scanMarker)
            {
                endpointDesinitions.AddRange(
                    marker.Assembly.ExportedTypes
                    .Where(x => typeof(IEndpointDefinition).IsAssignableFrom(x) && !x.IsAbstract)
                    .Select(Activator.CreateInstance)
                    .Cast<IEndpointDefinition>());
            }

            foreach (var endpoint in endpointDesinitions)
            {
                endpoint.DefineServices(service);
            }

            service.AddSingleton(endpointDesinitions as IReadOnlyCollection<IEndpointDefinition>);
        }

        public static void UseEndpointDefinitions(this WebApplication app)
        {
            var definitions = app.Services.
            GetRequiredService<IReadOnlyCollection<IEndpointDefinition>>();

            foreach (var endpointDefinition in definitions)
            {
                endpointDefinition.DefineEndpoints(app);
            }
        }
    }
}
