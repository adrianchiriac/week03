using System;

namespace _04.ArrayFindDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int[] vector = ArrayGetFromKB();
            if (vector.Length > 1)
            {
                bool[] duplicate = new bool[vector.Length];
                k = ArrayFindDuplicatesNumber(k, vector, duplicate);
                int[] vDuplicate = new int[k];
                int[] pozitie = new int[k];
                bool[] dupl = new bool[k];
                Console.WriteLine("Elementele duplicate din vector sint: ");
                DisplayDuplicatesVar1(vector, duplicate, vDuplicate, pozitie);
                Console.WriteLine();
                DisplayDuplicatesVar2(vDuplicate, pozitie, dupl);               // S-a urmarit o afisare diferita a duplicatelor
            }
            else
            {
                Console.WriteLine("Este necesar un numar de minim doua elemente!");
            }
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

        private static int ArrayFindDuplicatesNumber(int k, int[] vector, bool[] duplicate)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (!duplicate[i])
                    {
                        if (vector[i] == vector[j])
                        {
                            duplicate[j] = true;
                            k++;
                        }
                    }
                }
            }
            return k;
        }

        private static void DisplayDuplicatesVar1(int[] vector, bool[] duplicate, int[] vDuplicate, int[] pozitie)
        {
            int l = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (duplicate[i])
                {
                    Console.WriteLine("{0} (pozitia {1})  ", vector[i], i + 1);
                    vDuplicate[l] = vector[i];
                    pozitie[l] = i + 1;
                    l++;
                }
            }
        }

        private static void DisplayDuplicatesVar2(int[] vDuplicate, int[] pozitie, bool[] dupl)
        {
            for (int i = 0; i < vDuplicate.Length - 1; i++)
            {
                for (int j = i + 1; j < vDuplicate.Length; j++)
                {
                    if (vDuplicate[i] == vDuplicate[j])
                    {
                        dupl[j] = true;
                    }
                }
            }

            Console.WriteLine("Elementele duplicate din vector sint: ");
            for (int i = 0; i < vDuplicate.Length; i++)
            {
                if (!dupl[i])
                {
                    Console.Write("{0} - pozitia {1}", vDuplicate[i], pozitie[i]);
                    for (int j = i + 1; j < vDuplicate.Length; j++)
                    {
                        if (vDuplicate[i] == vDuplicate[j])
                        {
                            Console.Write(", {0}", pozitie[j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
