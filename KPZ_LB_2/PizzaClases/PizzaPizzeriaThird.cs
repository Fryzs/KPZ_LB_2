using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_LB_2.PizzaClases
{
    class PizzaPizzeriaThird : Pizza
    {
        public PizzaPizzeriaThird()
        {
            Name = "Гавайська";
            Dough = "Пухке тісто";
            Sauce = "Солодкий соус";
            Price = 200.0;
        }

        public override void Prepare()
        {
            Console.WriteLine("Готується піца Гавайська з ананасами і шинкою.");
        }

        public override string GetDescription()
        {
            return $"{Name}: {Dough}, {Sauce}, ціна {Price} грн";
        }
    }

}
