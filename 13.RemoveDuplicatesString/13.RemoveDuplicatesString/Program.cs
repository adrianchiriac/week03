using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.RemoveDuplicatesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sir = GetStringFromKB();
            Console.WriteLine("Sirul cu duplicate:   {0}", sir);
            string sirFaraDuplicate = RemoveDuplicates(sir);
            Console.WriteLine("Sirul fara duplicate: {0}", sirFaraDuplicate);
            Console.ReadLine();
        }

        private static string GetStringFromKB()
        {
            Console.Write("Introdu sirul: ");
            string str = Console.ReadLine();
            return str;
        }

        private static string RemoveDuplicates(string str)
        {
            bool[] duplicate = new bool[str.Length];
            string strWD = "";
            for (int i = 0; i < (str.Length - 1); i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        duplicate[j] = true;
                    }
                }
            }
            for (int i = 0; i < duplicate.Length; i++)
            {
                if (!duplicate[i])
                {
                    strWD = strWD + str[i];
                }
            }
            return strWD;
        }
    }
}
