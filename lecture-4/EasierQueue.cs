using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class EasierQueue<T>
    {
        //queue that uses normal list, not a linkedList

        private const int CAPACITY = 5;

        private T[] items = new T[CAPACITY];

        private int count = 0;

        public void Enqueue(T item)
        {
            if (count == CAPACITY)
            {
                Console.WriteLine("Queue is full! Corona rules apply and {0} has to keep social distance", item);
            }
            else
            {
                items[count] = item;
                count++;
            }
        }


        public T Dequeue() 
        {
            if (count==0)
            {
                throw new Exception();
            }

            T peek = items[0];

            for (int i = 1; i < count; i++)
            {
                items[i - 1] = items[i];
            }

            items[count - 1] = default;
            count--;

            return peek;
        }


        public T peek()
        {
            return items[0];
        }


        public bool IsEmpty()
        {
            return count == 0;
        }


        public int FirstIndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }


        public bool Contains(T item)
        {
            return FirstIndexOf(item) >= 0;
        }
    }
}
