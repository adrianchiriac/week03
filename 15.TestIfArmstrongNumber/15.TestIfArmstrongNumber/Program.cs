using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.TestIfArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar = GetNumberFromKB();
            string verdict = VerifyIfArmstrongNumber(numar);
            Console.WriteLine(verdict);
            Console.ReadLine();
        }

        private static int GetNumberFromKB()
        {
            Console.Write("Introdu numarul de verificat: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            return nr;
        }

        private static string VerifyIfArmstrongNumber(int nr)
        {
            string rezVer = "";
            int nrVer = nr;
            int sum = 0;
            do
            {
                sum = sum + (int)Math.Pow((nrVer % 10),3);
                nrVer = nrVer / 10;
            } while (nrVer != 0);
            if (sum == nr)
            {
                rezVer = "Numarul " + nr.ToString() + " este numar Armstrong!";
            }
            else
            {
                rezVer = "Numarul " + nr.ToString() + " nu este numar Armstrong!";
            }
            return rezVer;
        }

    }
}
