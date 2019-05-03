using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CheckIfPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar = GetNumberFromKB();
            string verdict = CheckIfPrimeNumber(numar);
            Console.WriteLine(verdict);
            Console.ReadLine();
        }

        private static int GetNumberFromKB()
        {
            Console.Write("Introdu numarul: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            return nr;
        }

        private static string CheckIfPrimeNumber(int nr)
        {
            string rezVer = "";
            if (nr <= 1)
            {
                if ((nr == 0) || (nr == 1))
                {
                    rezVer = nr + " nu este numar prim";
                }
                else
                {
                    rezVer = "Numerele negative nu pot fi numere prime (se divid cu -1)!";
                }
            }
            else
            {
                rezVer = "Numarul " + nr + " este prim";
                for (int i = 2; i < nr; i++)
                {
                    if (nr % i == 0)
                    {
                        rezVer = "Numarul " + nr + " nu este prim - se divide cu " + i;
                        break;
                    }
                }
            }

            return rezVer;
        }
    }
}
