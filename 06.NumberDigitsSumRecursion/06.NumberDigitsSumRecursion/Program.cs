using System;

namespace _06.NumberDigitsSumRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu numarul: ");
            int numar = Convert.ToInt32(Console.ReadLine());
            int sumaDigiti = suma(numar);
            Console.WriteLine("Suma digiti numar {0} = {1}", numar, sumaDigiti);
            Console.ReadLine();
        }

        private static int suma(int nr)
        {
            if (nr == 0)
            {
                return 0;
            }
            return (nr % 10) + suma(nr/10);
        }
    }
}
