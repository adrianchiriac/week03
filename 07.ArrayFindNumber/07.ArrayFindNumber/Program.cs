using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ArrayFindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = GetArrayFromKB();
            int nr = v.Length / 2;
            bool br = false;
            for (int i = 0; i < v.Length - 1; i++)
            {
                int frecventa = 1;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] == v[j])
                    {
                        frecventa++;
                        if (frecventa > nr)
                        {
                            Console.WriteLine("Numarul {0} are o frecventa > 50% in vector", v[i]);
                            br = true;
                            break;
                        }
                    }
                }
                if (br)
                {
                    break;
                }
            }
            if (!br)
            {
                Console.WriteLine("Nici un numar nu are o frecventa > 50% in vector");
            }
            Console.ReadLine();
        }

        private static int[] GetArrayFromKB()
        {
            Console.Write("Introdu numarul de elemente ale vectorului: ");
            int nrElem = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[nrElem];
            for (int i = 0; i < nrElem; i++)
            {
                Console.Write("Element {0}: ", i+1);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            return vector;
        }
    }
}
