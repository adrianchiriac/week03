using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = GetLinkedListFromKB();
            Console.Write("Lista initiala:          ");
            DisplayLinkedList(lista);
            LinkedList<int> listaInversata = ReverseLinkedListLoop(lista);
            Console.Write("Lista inversata (var.1): ");
            DisplayLinkedList(listaInversata);
            Console.Write("Lista inversata (var.2): ");
            LinkedList<int> listaInversata2 = ReverseSingleLinkedListLoop(lista);
            DisplayLinkedList(listaInversata2);
            Console.ReadLine();
        }

        private static LinkedList<int> GetLinkedListFromKB()
        {
            LinkedList<int> list = new LinkedList<int>();
            Console.Write("Intro numar elemente lista: ");
            int nrElem = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nrElem; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                list.AddLast(Convert.ToInt32(Console.ReadLine()));
            }
            return list;
        }

        private static LinkedList<int> ReverseLinkedListLoop(LinkedList<int> list)
        {
            int i = 1;
            int aux = 0;
            LinkedList<int> listaDePrelucrat = new LinkedList<int>();
            foreach (var item in list)
            {
                listaDePrelucrat.AddLast(item);
            }
            LinkedListNode<int> nod1 = listaDePrelucrat.First;
            LinkedListNode<int> nod2 = listaDePrelucrat.Last;
            while (i++ <= listaDePrelucrat.Count / 2)
            {
                aux = nod1.Value;
                nod1.Value = nod2.Value;
                nod2.Value = aux;
                nod1 = nod1.Next;
                nod2 = nod2.Previous;
            }
            return listaDePrelucrat;
        }

        private static LinkedList<int> ReverseSingleLinkedListLoop(LinkedList<int> list)
        {
            int i = 0;
            int[] array = new int[list.Count];
            LinkedList<int> listaDePrelucrat = new LinkedList<int>();
            foreach (var item in list)
            {
                array[i++] = item;
            }

            for (int j = array.Length - 1; j >= 0; j--)
            {
                listaDePrelucrat.AddLast(array[j]);
            }
            return listaDePrelucrat;
        }

        private static void DisplayLinkedList(LinkedList<int> list)
        {
            foreach (var element in list)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
