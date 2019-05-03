using System;

namespace _19.RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = GetArrayFromKB();
            int pivot = GetPivotFromKB();
            int[] vectorR = RotateArray(vector, pivot);
            DisplayArray("Vector initial: ", vector);
            DisplayArray("Vector final:   ", vectorR);
            Console.Read();
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

        private static int GetPivotFromKB()
        {
            Console.Write("Introdu valoare pivot: ");
            int valPivot = Convert.ToInt32(Console.ReadLine());
            return valPivot;
        }

        private static int[] RotateArray(int[] array, int nr)
        {
            if (nr >= array.Length)
            {
                nr = nr % array.Length;
            }
            int k = nr;
            int[] RotatedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (k <= (array.Length - 1))
                {
                    RotatedArray[k++] = array[i];
                }
                else
                {
                    RotatedArray[k++ - array.Length] = array[i];
                }
            }
            return RotatedArray;
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
