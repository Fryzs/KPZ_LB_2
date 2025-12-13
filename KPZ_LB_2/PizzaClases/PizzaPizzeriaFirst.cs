using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_LB_2.PizzaClases
{
    class PizzaPizzeriaFirst : Pizza
    {
        public PizzaPizzeriaFirst()
        {
            Name = "Маргарита";
            Dough = "Тонке тісто";
            Sauce = "Томатний";
            Price = 150.0;
        }

        public override void Prepare()
        {
            Console.WriteLine("Готується піца Маргарита з тонким тістом і томатним соусом.");
        }

        public override string GetDescription()
        {
            return $"{Name}: {Dough}, {Sauce}, ціна {Price} грн";
        }
    }
}
