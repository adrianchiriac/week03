using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CheckIfPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar = GetNumberFromKB();
            string verdict = CheckIfPalindrom(numar);
            Console.WriteLine(verdict);
            Console.ReadLine();
        }

        private static int GetNumberFromKB()
        {
            Console.Write("Introdu numarul: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            return nr;
        }

        private static string CheckIfPalindrom(int nr)
        {
            string rezVer = "Numarul " + nr + " este palindrom";
            string nrString = nr.ToString();
            for (int i = 0; i < nrString.Length/2; i++)
            {
                if (nrString[i] != nrString[nrString.Length - i - 1])
                {
                    rezVer = "Numarul " + nr + " nu este palindrom";
                    break;
                }
            }
            return rezVer;
        }
    }
}
