using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_LB_2.PizzaClases
{
    abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public double Price { get; set; }

        public abstract void Prepare();
        public abstract string GetDescription();
    }
}
