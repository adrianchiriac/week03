using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Merge2SortedLinkedListsVar2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista1 = GetListFromKB("lista 1");
            LinkedList<int> lista2 = GetListFromKB("lista 2");
            DisplayLinkedList("Lista 1:           ", lista1);
            DisplayLinkedList("Lista 2:           ", lista2);
            LinkedList<int> Merged2sortedLinkedList = Merge2sortedLinkedList(lista1, lista2);
            DisplayLinkedList("Lista 1 + Lista 2: ", Merged2sortedLinkedList);
            Console.ReadLine();
        }

        private static LinkedList<int> GetListFromKB(string mesaj)
        {
            Console.Write("Introdu numar elemente {0}: ", mesaj);
            int nrElem = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < nrElem; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                list.AddLast(Convert.ToInt32(Console.ReadLine()));
            }
            return list;
        }

        private static LinkedList<int> Merge2sortedLinkedList(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedList<int> MergedLinkedList = new LinkedList<int>();
            LinkedListNode<int> nodLista1 = list1.First;
            LinkedListNode<int> nodLista2 = list2.First;
            int l1List2 = 0;
            int l2List2 = 0;
            while (nodLista1 != null)
            {
                l1List2 = list2.Count;
                while (nodLista2 != null)
                {
                    if (nodLista1.Value < nodLista2.Value)
                    {
                        list2.AddBefore(nodLista2, nodLista1.Value);
                        break;
                    }
                    nodLista2 = nodLista2.Next;
                }
                l2List2 = list2.Count;
                if (l1List2 == l2List2)
                {
                    list2.AddLast(nodLista1.Value);
                }
                nodLista1 = nodLista1.Next;
            }
            return list2;
        }

        private static void DisplayLinkedList(string mesaj, LinkedList<int> list)
        {
            Console.Write(mesaj);
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}



