using System;

namespace ATMtransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            Meniu();
            Console.WriteLine();
            Console.WriteLine();
            char cr = ' ';
            int sold = 2000;
            while (cr != '4')
            {
                cr = SelectieOperatiune();
                Console.Clear();
                Meniu();
                if (cr == '1')
                {
                    Console.Write("  [  Sold = {0} lei  ]", sold);
                }
                else if (cr == '2')
                {
                    sold = RetragereNumerar(sold);
                }
                else if (cr == '3')
                {
                    sold = DepunereNumerar(sold);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.Write("  Ati ales sa nu efectuati nici o operatiune. Va multumim!");
            Console.ReadLine();

        }

        private static void Meniu()
        {
            Console.WriteLine("----- Tranzactii ATM -----");
            Console.WriteLine();
            Console.WriteLine("  1. Verificare sold");
            Console.WriteLine();
            Console.WriteLine("  2. Retragere numerar");
            Console.WriteLine();
            Console.WriteLine("  3. Depunere numerar");
            Console.WriteLine();
            Console.WriteLine("  4. Iesire");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        private static char SelectieOperatiune()
        {
            Console.Write("  Selectati operatiunea: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return ch;
        }

        private static int RetragereNumerar(int fnd)
        {
            if (fnd != 0)
            {
                Console.Write("  Suma de retras (lei): ");
                int retras = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Meniu();
                if (retras % 10 != 0)
                {
                    Console.Write("  [  Suma trebuie sa fie multiplu de 10  ]");
                }
                else
                {
                    if (retras > fnd)
                    {
                        Console.Write("  [  Fonduri insuficiente! ({0} lei > {1} lei)  ]", retras, fnd);
                    }
                    else
                    {
                        fnd -= retras;
                        Console.Write("  [  Ati retras {0} lei; sold = {1} lei  ]", retras, fnd);
                    }
                }
            }
            else
            {
                Console.Write("  [  Nu se pot efectua retrageri, soldul = {0} lei  ]", fnd);
            }
            return fnd;
        }

        private static int DepunereNumerar(int fnd)
        {
            Console.Write("  Suma de depus (lei): ");
            int depus = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Meniu();
            if (depus <= 0)
            {
                Console.Write("  [  Suma introdusa nu este corecta! ({0} lei)  ]", depus);
            }
            else
            {
                if (depus % 10 != 0)
                {
                    Console.Write("  [  Suma trebuie sa fie multiplu de 10  ]");
                }
                else
                {
                    fnd += depus;
                    Console.Write("  [  Ati depus {0} lei; sold = {1} lei  ]", depus, fnd);
                }
            }
            return fnd;
        }

    }
}
