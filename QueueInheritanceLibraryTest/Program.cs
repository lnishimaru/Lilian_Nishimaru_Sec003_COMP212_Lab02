﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueInheritanceLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing a list of int values and getting the minimum value

            var list = new LinkedListLibrary.LinkedList<string>(); // create List container

            // create data to store in List
            // use List insert methods       
            list.InsertAtFront("z"); // adding the first element or node
            list.InsertAtFront("b"); // adding the first element or node
            list.InsertAtFront("x"); // adding the first element or node
            list.InsertAtFront("a"); // adding the first element or node

            list.Display();
            Console.WriteLine($"Minimum: {list.Minimum()}");

            // testing a list of double values and getting the last element on queue

            var doubleList = new LinkedListLibrary.LinkedList<int>(); // create List container

            // create data to store in List
            // use List insert methods       
            doubleList.InsertAtFront(4); // adding the first element or node
            doubleList.InsertAtFront(3); // adding the first element or node
            doubleList.InsertAtFront(7); // adding the first element or node
            doubleList.InsertAtFront(9); // adding the first element or node

            Console.WriteLine("");
            doubleList.Display();
            Console.WriteLine($"Last Element: {doubleList.GetLast()}");

        }
    }
}
