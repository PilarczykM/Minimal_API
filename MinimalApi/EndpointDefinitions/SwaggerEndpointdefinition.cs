using Microsoft.OpenApi.Models;
using MinimalApi.Abstractions;

namespace MinimalApi.EndpointDefinitions
{
    public class SwaggerEndpointdefinition : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
            }
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minimal Api", Version = "v1" });
            });
        }
    }
}
