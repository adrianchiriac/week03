using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            //string strFile = "C:\\Users\\Public\\file.txt";
            string strFile = @"C:\Users\Public\file.txt";
            if (File.Exists(strFile))
            {
                StreamReader fileR = new StreamReader(strFile);
                string line;
                while ((line = fileR.ReadLine()) != null)
                {
                    list.Add(Convert.ToInt32(line));
                }
                fileR.Close();
                int suma = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    suma += list[i];
                }
                StreamWriter fileW = new StreamWriter(strFile, true);
                fileW.WriteLine(suma.ToString());
                fileW.Close();
            }
            else
            {
                Console.WriteLine("Nu exista fisierul specificat!");
                Console.ReadLine();
            }
        }
    }
}
