﻿using MinimalApi.Abstractions;
using MinimalApi.Models;
using MinimalApi.Repositories;

namespace MinimalApi.EndpointDefinitions
{
    public class CustomerEndpointDefinition : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/customers", GetAllCustomers);
            app.MapGet("/customers/{id}", GetCustomerById);
            app.MapPost("/customers", CreateCustomer);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);
        }

        internal IResult GetAllCustomers(CustomerRepository repository)
        {
            return Results.Ok(repository.GetAll());
        }

        internal IResult GetCustomerById(ICustomerRepository repository, Guid id)
        {
            var customer = repository.GetById(id);
            return customer is not null ? Results.Ok(customer) : Results.NotFound();
        }

        internal IResult CreateCustomer(ICustomerRepository repository, Customer customer)
        {
            repository.Create(customer);
            return Results.Created($"/customers/{customer.Id}", customer);
        }

        internal IResult UpdateCustomer(ICustomerRepository repository, Guid id, Customer updatedCustomer)
        {
            var customer = repository.GetById(id);

            if (customer is null)
            {
                return Results.NotFound();
            }

            repository.Update(updatedCustomer);
            return Results.Ok(updatedCustomer);
        }

        internal IResult DeleteCustomer(ICustomerRepository repository, Guid id)
        {
            repository.Delete(id);
            return Results.Ok();
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
        }
    }
}
