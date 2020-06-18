using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babochkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            butterfly babochka = new butterfly("лимонница", 10 );

            babochka.butterflyMethod();


            Console.Read();
        }
    }

    class butterfly
    {
        protected string Name { get; set; }
        protected int Years { get; set; }

        public butterfly(string name, int years)
        {
            Name = name;
            Years = years;
            Console.WriteLine("Родительский класс создан");
        }

        public virtual void butterflyMethod()
        {
            Console.WriteLine("Бабочка: {0} может жить {1} месяцев ", Name, Years);
        }

      
    }

    class Babochka : butterfly
    {
        public Babochka(string name, int years) : base(name, years)
        {
            Name = name;
            Years = years;
            Console.WriteLine("Дочерний класс создан");
        }

        public override void butterflyMethod()
        {
            Console.WriteLine("Бабочка {0} которая живёт {1} месяцев являеться самой долгожительной", Name, Years);
        }
    }
}
