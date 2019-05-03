using System;
using System.Collections.Generic;

namespace _02.ArrayPairElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = ArrayGetFromKB();
            Console.Write("Introdu suma dorita: ");
            int SumaDorita = Convert.ToInt32(Console.ReadLine());
            List<int> perechi = ArrayPairElementsSum(vector, SumaDorita);
            Console.WriteLine("Lista perechi numere a caror suma este egala cu {0}: ", SumaDorita);
            AfisareListaPerechi(perechi);
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

        private static List<int> ArrayPairElementsSum(int[] array, int sum)
        {
            List<int> listaPerechi = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        if (!listaPerechi.Contains(array[i]))
                        {
                            listaPerechi.Add(array[i]);
                            listaPerechi.Add(array[j]);
                        }
                    }
                }
            }
            Console.WriteLine();
            return listaPerechi;
        }

        private static void AfisareListaPerechi(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i += 2)
            {
                Console.WriteLine("{0}, {1}", lista[i], lista[i + 1]);
            }
        }

    }
}
