using Furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture
{
    public class ConsumerUnit : Product
    {
        public string CatalogNumber { get; set; }
       
        public ConsumerUnit(string name, decimal price, Category category, string catalogNumber)
            : base(name, price, category)
        {
            CatalogNumber = catalogNumber;
        }
    }
}
