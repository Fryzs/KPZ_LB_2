using KPZ_LB_2.PizzaClases;
using KPZ_LB_2.PizzeriaClases;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace KPZ_LB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPizza(new PizzeriaFirst());
        }
        private void ShowPizza(Pizzeria pizzeria)
        {
            Pizza pizza = pizzeria.CreatePizza();
            pizza.Prepare();
            textBox1.Text =
                $"Назва: {pizza.Name}\r\n" +
                $"Тісто: {pizza.Dough}\r\n" +
                $"Соус: {pizza.Sauce}\r\n" +
                $"Ціна: {pizza.Price} грн\r\n\r\n" +
                $"Опис: {pizza.GetDescription()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPizza(new PizzeriaSecond());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPizza(new PizzeriaThird());
        }
    }
}
