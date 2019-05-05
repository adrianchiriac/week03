using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int an = GetNumberFromKB();
            string verdict = ChekIfLeapYear(an);
            Console.WriteLine(verdict);
            Console.ReadLine();
        }

        private static int GetNumberFromKB()
        {
            Console.Write("Introdu anul: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            return nr;
        }

        private static string ChekIfLeapYear(int nr)
        {
            string rez = "";
            if (nr % 400 == 0)
            {
                rez = "Anul " + nr.ToString() + " este an bisect.";
            }
            else if (nr % 100 == 0)
            {
                rez = "Anul " + nr.ToString() + " nu este an bisect.";
            }
            else
            {
                if (nr % 4 == 0)
                {
                    rez = "Anul " + nr.ToString() + " este an bisect.";
                }
                else
                {
                    rez = "Anul " + nr.ToString() + " nu este an bisect.";
                }
            }
            return rez;
        }
    }
}
