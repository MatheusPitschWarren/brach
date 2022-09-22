﻿using AppServices.Interfaces;
using DomainModel.Model;
using DomainServices.Interfaces;
using System;
using System.Collections.Generic;

namespace AppServices.AppServices;

public class CustomersAppServices : ICustomersAppServices
{
    private readonly ICustomerServices _customerServices;

    public CustomersAppServices(ICustomerServices baseServices)
    {
        _customerServices = baseServices ?? throw new ArgumentNullException(nameof(baseServices));
    }

    public long Create(Customer model)
    {
        return _customerServices.Create(model);
    }

    public void Delete(long id)
    {
        _customerServices.Delete(id);
    }

    public IEnumerable<Customer> GetAll()
    {
        return _customerServices.GetAll();
    }

    public Customer GetById(long id)
    {
        return _customerServices.GetById(id);
    }

    public bool Update(Customer model)
    {
        return _customerServices.Update(model);
    }
}
