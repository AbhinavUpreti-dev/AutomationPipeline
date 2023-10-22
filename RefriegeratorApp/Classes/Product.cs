using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Quantity{ get; set; }

        public ProductType Type { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
