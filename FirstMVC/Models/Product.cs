using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public  int UnitPrice { get; set; }
    }
}
