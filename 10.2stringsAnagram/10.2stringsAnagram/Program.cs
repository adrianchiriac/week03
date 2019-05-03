using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2stringsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string sir1 = "acoperit";       //  alt ex.: concert / concret
            string sir2 = "ipotecar";
            Console.WriteLine("Sir 1: {0}\nSir 2: {1}", sir1, sir2);
            string verdict = Verify2stringsIfAnagram(sir1, sir2);
            Console.WriteLine(verdict);
            Console.ReadLine();
        }

        private static string Verify2stringsIfAnagram(string str1, string str2)
        {
            string rezComp = "";
            List<char> ListSir1 = new List<char>(str1);
            List<char> ListSir2 = new List<char>(str2);
            if (ListSir1.Count == ListSir2.Count)
            {
                for (int i = 0; i < ListSir1.Count; i++)
                {
                    for (int j = 0; j < ListSir2.Count; j++)
                    {
                        if (ListSir1[i] == ListSir2[j])
                        {
                            ListSir2.Remove(ListSir2[j]);
                            break;
                        }
                    }
                }
                if (ListSir2.Count == 0)
                {
                    rezComp = "Cele doua siruri sint anagrame!";
                }
                else
                {
                    rezComp = "Cele doua siruri nu sint anagrame!";
                }
            }
            else
            {
                rezComp = "Cele doua siruri nu sint anagrame!";
            }

            return rezComp;
        }
    }
}
