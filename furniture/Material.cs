using Furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture
{
    public class Material : Product
    {
        public Material(string name, decimal price, Category category)
        : base(name, price, category) { }
    }
}
