using KPZ_LB_2.PizzaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_LB_2.PizzeriaClases
{
    abstract class Pizzeria
    {
        public abstract Pizza CreatePizza();

        public void PreparePizza()
        {
            Pizza pizza = CreatePizza();
            pizza.Prepare();
            Console.WriteLine(pizza.GetDescription());
        }
    }
}
