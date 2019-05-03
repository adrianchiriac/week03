using System;
using System.Collections.Generic;

namespace _09.Merge2SortedLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] v1 = new int[] { 10, 20, 30 };
            //int[] v2 = new int[] { 5, 25, 27 };
            Console.WriteLine("Creare lista 1");
            int[] v1 = GetArrayFromKB();
            Console.WriteLine();
            Console.WriteLine("Creare lista 2");
            int[] v2 = GetArrayFromKB();
            Console.WriteLine();
            LinkedList<int> lista1 = new LinkedList<int>(v1);
            LinkedList<int> lista2 = new LinkedList<int>(v2);
            LinkedList<int> MergedList = new LinkedList<int>();
            AddElementsToLinkedList(MergedList, lista1);
            AddElementsToLinkedList(MergedList, lista2);
            LinkedList<int> SortedMergedLinkedList = SortMergedLinkedList(MergedList);
            Console.Write("Lista contopita, sortata: ");
            DisplayLinkedList(SortedMergedLinkedList);
            Console.ReadLine();
        }

        private static int[] GetArrayFromKB()
        {
            Console.Write("Introdu numarul de elemente: ");
            int nrElem = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[nrElem];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        private static LinkedList<int> AddElementsToLinkedList(LinkedList<int> list1, LinkedList<int> list2)
        {
            foreach (var item in list2)
            {
                list1.AddLast(item);
            }
            return list1;
        }

        private static LinkedList<int> SortMergedLinkedList(LinkedList<int> list)
        {
            LinkedListNode<int> nod_ant = list.First;
            LinkedListNode<int> nod_crt = nod_ant.Next;
            int aux = 0;
            foreach (var item in list)
            {
                while (nod_crt != null)
                {
                    if (nod_ant.Value > nod_crt.Value)
                    {
                        aux = nod_crt.Value;
                        nod_crt.Value = nod_ant.Value;
                        nod_ant.Value = aux;
                    }
                    nod_crt = nod_crt.Next;
                }
                if (nod_ant.Next != null)
                {
                    nod_ant = nod_ant.Next;
                }
                nod_crt = nod_ant.Next;
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
