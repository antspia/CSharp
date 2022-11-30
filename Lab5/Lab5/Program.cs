using System;

namespace Lab5
{
    class Program
    {
        static int[,] GenerateArr(int row, int col)

        {

            int[,] arr = new int[row, col];

            Random x = new Random();

            for (int i = 0; i < row; i++)

                for (int j = 0; j < col; j++)

                    arr[i, j] = x.Next(-100, 100);

            return arr;

        }
        static void PrintArr(int[,] arr)

        {

            for (int i = 0; i < arr.GetLength(0); i++)

            {

                for (int j = 0; j < arr.GetLength(1) - 1; j++)

                {

                    Console.Write(arr[i, j].ToString() + "\t");

                }

                Console.WriteLine(arr[i, arr.GetLength(1) - 1]);

            }

        }

        static void Main(string[] args)
        {
            int m = 0;
            do
            {
                Console.WriteLine("Введiть к-сть рядкiв: ");
                 m = int.Parse(Console.ReadLine());
            } while (m <= 0);
            int n = 0;
            do {
                Console.WriteLine("Введiть к-сть стовпчикiв: ");
                 n = int.Parse(Console.ReadLine());
            }while(n<= 0);
            Console.WriteLine(" ");
            int[,] arr = new int[m, n];
            arr = GenerateArr(m, n);
            Console.WriteLine("Згенерований масив: ");
            PrintArr(arr);
            

            int min = arr[0, 0], indexImin = 0, indexJmin = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        indexImin = i;
                        indexJmin = j;
                    }
                }
            }

            Console.WriteLine("Рядок з мiнiмальним елементом: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[indexImin, j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ствопчик з мiнiмальним елементом: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write(arr[i, indexJmin] + " ");
            }
            Console.WriteLine();



            int max = arr[0, 0], indexImax = 0, indexJmax = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        indexImax = i;
                        indexJmax = j;
                    }
                }
            }

            Console.WriteLine("Рядок з максимальним елементом: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[indexImax, j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Стовпчик з максимальним елементом: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write(arr[i, indexJmax] + " ");
            }
            Console.WriteLine();
        }
    }
}