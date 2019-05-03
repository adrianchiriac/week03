using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> FibonacciList = new List<int> { 0, 1 };
            int n = ReadNumberFromKB();
            if (n>=3)
            {
                CompleteFibonacciSeries(FibonacciList, n);
            }
            DisplayFibonacciNumber(FibonacciList, n);
            Console.ReadLine();
        }

        private static void CompleteFibonacciSeries(List<int> FibonacciList, int n)
        {
            int nth;
            for (int i = 0; i < n - 2; i++)
            {
                nth = FibonacciList[i] + FibonacciList[i + 1];
                FibonacciList.Add(nth);
            }
        }

        private static int ReadNumberFromKB()
        {
            Console.Write("Introdu pozitia din sirul Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        private static void DisplayFibonacciNumber(List<int> serie, int nr)
        {
            if (nr < 1)
            {
                Console.WriteLine("Nu se poate calcula numarul de pe pozitia dorita!");
            }
            else
                Console.WriteLine("Numarul de pe pozitia {0} din sirul Fibonacci este {1}", nr, serie[nr - 1]);
        }
    }
}
