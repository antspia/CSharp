using System;
namespace LR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число для перевiрки");
            int num=int.Parse(Console.ReadLine());
            bool x;
            if (num % 2 != 0 && num/100>0&&num/100<10)
            {
                x = true;
            }
            else { x= false; }
            Console.WriteLine($"Дане число є трьохзначним i непарним: {x}");
            Console.ReadKey();

        }
    }
}