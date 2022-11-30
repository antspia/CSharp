using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nk = -1;
            while (nk < 0)
            {
                Console.WriteLine("Введiть nk: ");
                string strnk = Console.ReadLine();
                int.TryParse(strnk, out nk);
                if (nk < 0) Console.WriteLine("Помилка (nk < 0) ");
            }

            int nn = -1;
            while (nn < 0)
            {
                Console.WriteLine("Введiть nn: ");
                string strnn = Console.ReadLine();
                int.TryParse(strnn, out nn);
                if (nn < 0) Console.WriteLine("Помилка (nn < 0) ");
                if (nk < nn) Console.WriteLine("Помилка (nn > nk) ");
            }

            double result = 0;
            while (nn <= nk)
            {
                result += (3 * nn + Math.Pow(-1, (Math.Pow(nn, 2) - nn + 1) * nn)) / (2 * Math.Pow(nn, 2) + 1);
                nn++;
            }

            Console.WriteLine($"Результат : {result}");



        }
    }
}