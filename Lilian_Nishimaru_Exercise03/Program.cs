using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace Lilian_Nishimaru_Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing a list of int values and getting the minimum value

            var list = new LinkedListLibrary.LinkedList<int>(); // create List container
            
            // create data to store in List
            // use List insert methods       
            list.InsertAtFront(11); // adding the first element or node
            list.InsertAtFront(14); // adding the first element or node
            list.InsertAtFront(1); // adding the first element or node
            list.InsertAtFront(3); // adding the first element or node

            list.Display();
            Console.WriteLine($"Minimum: {list.Minimum()}");

            // testing a list of double values and getting the last element on queue

            var doubleList = new LinkedListLibrary.LinkedList<double>(); // create List container

            // create data to store in List
            // use List insert methods       
            doubleList.InsertAtFront(4.5); // adding the first element or node
            doubleList.InsertAtFront(3); // adding the first element or node
            doubleList.InsertAtFront(7.8); // adding the first element or node
            doubleList.InsertAtFront(9.6); // adding the first element or node
            
            Console.WriteLine("");
            doubleList.Display();
            Console.WriteLine($"Last Element: {doubleList.GetLast()}");

        }
    }
}
