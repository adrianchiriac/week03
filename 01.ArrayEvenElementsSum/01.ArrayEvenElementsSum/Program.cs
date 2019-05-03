using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayEvenElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = ArrayGetFromKB();
            int suma = ArrayEvenElementsSum(vector);
            Console.WriteLine("Suma elementelor pare din vector este {0}", suma);
            Console.ReadLine();
        }

        private static int[] ArrayGetFromKB()
        {
            Console.Write("Introdu numar elemente vector: ");
            int NrElem = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[NrElem];

            for (int i = 0; i < NrElem; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        private static int ArrayEvenElementsSum(int[] array)
        {
            int sum = 0;
            Console.Write("Elementele pare ale vectorului: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write("{0} ", array[i]);
                    sum = sum + array[i];
                }
            }
            Console.WriteLine();
            return sum;
        }

    }
}
