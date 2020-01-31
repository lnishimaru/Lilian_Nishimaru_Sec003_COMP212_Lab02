using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueInheritanceLibrary
{
    // class QueueInheritance inherits List's capabilities
    public class QueueInheritance<T> : LinkedListLibrary.LinkedList<T> where T : IComparable<T>
    {
        // pass name "queue" to List constructor
        public QueueInheritance() : base("queue") { }

        // place dataValue at end of queue by inserting 
        // dataValue at end of linked list
        public void Enqueue(T dataValue)
        {
            InsertAtBack(dataValue);
        }

        // remove item from front of queue by removing
        // item at front of linked list
        public T Dequeue()
        {
            return RemoveFromFront();
        }

        // returns the last value on queue  
        public new T GetLast()
        {
            return GetLast();
        }

    }
}
