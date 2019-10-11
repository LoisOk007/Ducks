using System;
using FirstLab.Ducks;
using FirstLab;

namespace TestApp
{
    class Program
    {
        static void Info(BaseDuck duck)
        {
            duck.Display();duck.Fly();
            duck.Quack();duck.Swim();
        }
        static void Main()
        {
            Console.WriteLine("Тест 1:");
            UsualDuck duck1 = new UsualDuck();
            Info(duck1);
            SmallDuck duck2 = new SmallDuck();
            Info(duck2);
            WoodenDuck duck3 = new WoodenDuck();
            Info(duck3);

            Console.WriteLine("\nТест 2:");
            Info(new DecoyDuck());
            Info(new RubberDuck());

            Console.WriteLine("\nТест 3:");
            BaseDuck duck4 = new RoboDuck();
            Info(duck4);
            Console.ReadLine();
        }
    }
}
