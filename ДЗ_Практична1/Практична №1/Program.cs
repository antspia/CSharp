using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Практична__1
{
    class Program
    {
        static void Main()
        {
            var sum = 0.0;
            var N = 10;
            double[] arr= new double[N];
            for(int i = 0; i < N; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                if (i % 2 != 0) sum += arr[i];
            }
            Console.WriteLine($"Sum is {sum}");
            Console.ReadKey();
        }
    }
}
