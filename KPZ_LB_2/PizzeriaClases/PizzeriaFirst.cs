using KPZ_LB_2.PizzaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_LB_2.PizzeriaClases
{
    class PizzeriaFirst : Pizzeria
    {
        public override Pizza CreatePizza()
        {
            return new PizzaPizzeriaFirst();
        }
    }
}
