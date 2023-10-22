using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    public class Purchase
    {
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
