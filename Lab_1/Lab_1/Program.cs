using System;

namespace Lab_1
{
    class Program
    {


        public static double Func(int x)
        {
            double y=0;
            if (x == 1)
            {
                Console.WriteLine("Введiть перший лiтраж води");
                y = double.Parse(Console.ReadLine());
                return y;
            }
            else if (x == 2)
            {
                Console.WriteLine("Введiть першу температуру води ");
                y = double.Parse(Console.ReadLine());
                return y;
            }
            else if (x == 3)
            {
                Console.WriteLine("Введiть другий лiтраж води ");
                y = double.Parse(Console.ReadLine());
                return y;
            }
            else if (x == 4)
            {
                Console.WriteLine("Введiть другу температуру води ");
                y = double.Parse(Console.ReadLine());
                return y;
            }
            else return 0;


        }

        static void Main(string[] args)
        {
            double v1;
            v1 = Func(1);

            double t1;
            t1 = Func(2);


            double v2;
            v2 = Func(3);

            double t2;
            t2 = Func(4);

            double result;
            result = ((v2 * t2) + (v1 * t1)) / (v1 + v2);
            Console.WriteLine($"Температура розчину води становить {result} градусiв");
            Console.ReadKey();
        }
    }
}
