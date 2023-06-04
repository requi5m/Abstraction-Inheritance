using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class NonRealCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxName { get; set; }
    }
}
