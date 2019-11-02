using BirdLibrary;
using BirdLibrary.Adapters;
using BirdLibrary.Birds;
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
        static void Info(BaseBird bird)
        {
            bird.Display(); bird.Fly();
            bird.Sound(); bird.Swim();
            Console.WriteLine();
        }
        static void Test1()
        {

            Console.WriteLine("Тест 1(Создание уточек):");
            UsualDuck duck1 = new UsualDuck();
            Info(duck1);
            SmallDuck duck2 = new SmallDuck();
            Info(duck2);
            WoodenDuck duck3 = new WoodenDuck();
            Info(duck3);
            Info(new DecoyDuck());
            Info(new RubberDuck());
            BaseDuck duck4 = new RoboDuck();
            Info(duck4);
        }
        static void Test2()
        {
            Console.WriteLine("Тест 2(Использование фабрики уточек):");
            var qc = new QuackCreator();
            var sc = new SwimCreator();
            var duck1 = new DuckCreator(new FlyCreator(), qc, sc).Create(FlyType.FlyHigh, QuackType.RoboQuack, SwimType.Swim);
            Info(duck1);
            var duck2 = new DuckCreator(new NotFlyFactory(), qc, sc).Create(FlyType.FlyHigh, QuackType.RoboQuack, SwimType.RoboSwim);
            Info(duck2);
        }
        static void Test3()
        {
            Console.WriteLine("Тест 3(Создание птиц):");
            var pigeon = new Pigeon();
            Info(pigeon);
            var penguin = new Penguin();
            Info(penguin);
        }

        static void Test4()
        {
            Console.WriteLine("Тест 4(адаптирование птиц, под уточек):");
            var duck1 = new BirdAdapter(new Penguin());
            Info(duck1);
            var duck2 = new BirdAdapter(new Raven());
            Info(duck2);
        }
        static void Main()
        {
            int n;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите тип задачи:");
                Console.WriteLine("1)Уточки (Паттерн:Стратегия);");
                Console.WriteLine("2)Фабрика уточек (Паттерн:Фабрика);");
                Console.WriteLine("3)Создание птиц(промежуточный класс);");
                Console.WriteLine("4)Использование адаптера для птиц(Паттерн:Адаптер)$");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1: Test1(); break;
                        case 2: Test2(); break;
                        case 3: Test3(); break;
                        case 4: Test4(); break;
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
