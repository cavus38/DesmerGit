using PluralWcfService.Data;
using PluralWcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PluralWcfService.Services
{
    
  
    public class PluralWcfService:IPluralWcfService
    {
        readonly PluralDbContext _context = new PluralDbContext();// github test comment asd
        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
