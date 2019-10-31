using System;
using System.Collections.Generic;

namespace EFCoreWeb.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }
}
