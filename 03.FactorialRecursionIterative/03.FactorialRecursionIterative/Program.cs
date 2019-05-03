using System;

namespace _03.FactorialRecursionIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu numarul pentru care calculam factorialul: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            if (nr >= 0)
            {
                int factI = FactorialIterative(nr);
                Console.WriteLine("Factorialul lui {0} este {1}", nr, factI);
            }
            else
            {
                Console.WriteLine("Nu se poate calcula factorialul unui numar negativ!");
            }

            if (nr >= 0)
            {
                int factR = FactorialRecursiv(nr);
                Console.WriteLine("Factorialul lui {0} este {1}", nr, factR);
            }
            else
            {
                Console.WriteLine("Nu se poate calcula factorialul unui numar negativ!");
            }

            Console.ReadLine();
        }

        private static int FactorialIterative(int numar)
        {
            int factorialI = 1;
            if (numar > 0)
            {
                for (int i = 1; i <= numar; i++)
                {
                    factorialI = factorialI * i;
                }
            }
            return factorialI;
        }

        private static int FactorialRecursiv(int numar)
        {
            if (numar == 0)
            {
                return 1;
            }
            return numar * FactorialRecursiv(numar-1);
        }

    }
}
