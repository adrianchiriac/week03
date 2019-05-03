using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._3thElementLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = GetListFromKB();
            if (lista.Count > 2)
            {
                int n3 = Find3thElementLinkedList(lista);
                Console.WriteLine("Al 3-lea element de la sfirsitul listei este {0}", n3);
            }
            else
            {
                Console.WriteLine("Lista contine mai putin de 3 elemente ({0})!", lista.Count);
            }
            Console.ReadLine();
        }

        private static LinkedList<int> GetListFromKB()
        {
            Console.Write("Introdu numarul de elemente ale listei: ");
            int numar = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < numar; i++)
            {
                Console.Write("Element {0}: ", i+1);
                list.AddLast(Convert.ToInt32(Console.ReadLine()));
            }
            return list;
        }

        private static int Find3thElementLinkedList(LinkedList<int> list)
        {
            LinkedListNode<int> nod1 = list.First;
            LinkedListNode<int> nod2 = nod1.Next.Next;
            if (nod2 != null)
            {
                while (nod2.Next != null)
                {
                    nod1 = nod1.Next;
                    nod2 = nod2.Next;
                }
            }
            return nod1.Value;
        }
    }
}
