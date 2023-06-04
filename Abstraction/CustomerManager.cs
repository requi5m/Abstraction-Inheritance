using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class CustomerManager
    {
        public void Add(List<Customer> customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine(customers.Id);
            }
        }
    }
}
