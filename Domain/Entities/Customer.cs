using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

internal class Customer
{
    public int CustomerId { get; set; }
    public string CustomerFName { get; set; }
    public string CustomerLName { get; set; }
    public int PhoneNumber { get; set; }

}
