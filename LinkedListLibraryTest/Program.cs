using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedListLibrary.LinkedList<int>(); // create List container

            // create data to store in List
            // use List insert methods       
            list.InsertAtFront(11); // adding the first element or node
            list.InsertAtFront(14); // adding the first element or node
            list.InsertAtBack(1);   // adding the last element or node
            list.InsertAtFront(3);  // adding the first element or node

            list.Display();

            list.RemoveFromFront(); //remove the first element
            list.RemoveFromBack();  //remove the last element
            list.Display();

        }
    }
}
