using System;

namespace _20.ArraySelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = GetArrayFromKB();
            DisplayArray("Vector initial: ", vector);
            vector = ArraySelectionSort(vector);
            DisplayArray("Vector sortat:  ", vector);
            Console.ReadLine();
        }

        private static int[] GetArrayFromKB()
        {
            Console.Write("Introdu numarul de elemente ale vectorului: ");
            int nrElem = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[nrElem];
            for (int i = 0; i < nrElem; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        private static int[] ArraySelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        array[i] = array[i] + array[j];
                        array[j] = array[i] - array[j];
                        array[i] = array[i] - array[j];
                    }
                }
            }
            return array;
        }

        private static void DisplayArray(string mesaj, int[] array)
        {
            Console.Write(mesaj);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
