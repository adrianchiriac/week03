using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SumSetBitsInt32
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar = GetNumberFromKB();
            int sumaI = SumSetBitsIterativ(numar);
            Console.WriteLine("== Metoda iterativa ==  Suma bitilor = {0}", sumaI);
            int sumaR = SumSetBitsIterativ(numar);
            Console.WriteLine("== Metoda recursiva ==  Suma bitilor = {0}", sumaR);
            Console.ReadLine();
        }

        private static int GetNumberFromKB()
        {
            Console.Write("Introdu numarul: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            return nr;
        }

        private static int SumSetBitsIterativ(int nr)
        {
            int sum = 0;
            do
            {
                sum = sum + (nr % 2);
                nr = nr / 2;
            } while (nr != 0);
            return sum;
        }

        private static int SumSetBitsRecursiv(int nr)
        {
            int sum = 0;
            if (nr == 0)
            {
                return 0;
            }
            return sum + SumSetBitsRecursiv(nr % 2);
        }

    }
}
