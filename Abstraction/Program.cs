using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new RealCustomer()
            {
                Id = 1, CustomerNo = "123", Name = "Yigit", LastName = "Altinay"
            };
            Customer customer2 = new NonRealCustomer()
            {
                Id = 2, CustomerNo = "1234", CompanyName = "Company", TaxName = "12345"
            };

            //I made this here myself if you want you can delete it or add other methods.
            List<Customer> customers = new List<Customer>() {customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customers);
        }
    }
}
