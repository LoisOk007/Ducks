using DuckLibrary;
using DuckLibrary.DuckFactory;
using DuckLibrary.Ducks;
using DuckLibrary.FlyFactory;
using DuckLibrary.QuackFactory;
using DuckLibrary.SwimFactory;
using System;

namespace TestApp
{
    class Program
    {
        static void Info(BaseDuck duck)
        {
            duck.Display(); duck.Fly();
            duck.Quack(); duck.Swim();
            Console.WriteLine();
        }
        static void Test1()
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
        }
        static void Test2()
        {
            var qc = new QuackCreator();
            var sc = new SwimCreator();
            var duck1 = new DuckCreator(new FlyCreator(), qc, sc).Create(FlyType.FlyHigh, QuackType.RoboQuack, SwimType.Swim);
            Info(duck1);
            var duck2 = new DuckCreator(new NotFlyFactory(), qc, sc).Create(FlyType.FlyHigh, QuackType.RoboQuack, SwimType.RoboSwim);
            Info(duck2);
        }
        static void Test3()
        {
            Console.WriteLine("Добро пожаловать в конструктор уточки:");
            
        }
        static void Main()
        {
            int n;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите тип задачи:");
                Console.WriteLine("1)Уточки (Паттерн:Стратегия),");
                Console.WriteLine("2)Фабрика уточек (Паттерн:Фабрика).");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1: Test1(); break;
                        case 2: Test2(); break;
                        case 3: Test3(); break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.WriteLine("Повторить ? 1 - да");
            } while (Console.ReadLine() == "1");
        }
    }
}
