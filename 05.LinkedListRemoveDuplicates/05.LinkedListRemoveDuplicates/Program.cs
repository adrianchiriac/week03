using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LinkedListRemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = GetLinkedListFromKB();
            Console.Write("Lista initiala:       ");
            DisplayLinkedList(lista);
            Console.WriteLine();
            LinkedList<int> listaFaraDuplicate = RemoveDuplicatesLinkedList(lista);
            Console.Write("Lista fara duplicate: ");
            DisplayLinkedList(listaFaraDuplicate);
            Console.ReadLine();
        }

        private static LinkedList<int> GetLinkedListFromKB()
        {
            Console.Write("Introdu numar elemente lista: ");
            int NrEl = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < NrEl; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                list.AddLast(Convert.ToInt32(Console.ReadLine()));
            }
            return list;
        }

        private static LinkedList<int> RemoveDuplicatesLinkedList(LinkedList<int> list)
        {
            LinkedListNode<int> nodAnt = list.First;
            LinkedListNode<int> nodCrt = nodAnt.Next;
            int ct = 1;
            while (ct < list.Count - 1)
            {
                while (nodCrt != null)
                {
                    if (nodAnt.Value == nodCrt.Value)
                    {
                        list.Remove(nodCrt);
                        nodCrt = nodAnt.Next;
                    }
                    else
                    {
                        nodCrt = nodCrt.Next;
                    }
                }
                ct++;
                nodAnt = nodAnt.Next;
                if (nodAnt != null)
                {
                    nodCrt = nodAnt.Next;
                }
            }
            return list;
        }

        private static void DisplayLinkedList(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
