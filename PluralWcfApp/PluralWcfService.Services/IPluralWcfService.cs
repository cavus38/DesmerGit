using PluralWcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace PluralWcfService.Services
{

    [ServiceContract]
    public interface IPluralWcfService
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract]
        List<Customer> GetCustomers();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}
