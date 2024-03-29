﻿namespace MinimalApi;

internal interface ICustomerRepository
{
    void Create(Customer? customer);
    void Delete(Guid id);
    List<Customer> GetAll();
    Customer? GetById(Guid Id);
    void Update(Customer customer);
}
