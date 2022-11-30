using System;
namespace LR_4
{
    class Program
    {
        static void Ins(ref int[] arr, int value, int index)
        {
            int[] newArray = new int[arr.Length + 1];
            newArray[index] = value;

            for(int i=0;i<index;i++)
                newArray[i] = arr[i];

            for(int i = index; i < arr.Length; i++)
                newArray[i+1] = arr[i];

            arr= newArray;
        }
        static void Main(string[] args)
        {
            int N = 0;
            do
            {
                Console.WriteLine("Введiть довжину масиву(більше нуля): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0);

                int[] arr = new int[N];

            Random x = new Random();
            for (int i = 0; i < N; i++)
                arr[i] = x.Next(0, 9);

            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine(" ");


            for(int i=0;i<arr.Length+1;i+=2)
                Ins(ref arr, 0, i);
                

            foreach (int i in arr)
                Console.Write($"{i} ");
        }
    }
}