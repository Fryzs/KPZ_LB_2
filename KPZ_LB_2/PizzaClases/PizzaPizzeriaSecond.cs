using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_LB_2.PizzaClases
{
    class PizzaPizzeriaSecond : Pizza
    {
        public PizzaPizzeriaSecond()
        {
            Name = "Пепероні";
            Dough = "Товсте тісто";
            Sauce = "Гострий томатний";
            Price = 180.0;
        }

        public override void Prepare()
        {
            Console.WriteLine("Готується піца Пепероні з товстим тістом і гострим соусом.");
        }

        public override string GetDescription()
        {
            return $"{Name}: {Dough}, {Sauce}, ціна {Price} грн";
        }
    }
}

