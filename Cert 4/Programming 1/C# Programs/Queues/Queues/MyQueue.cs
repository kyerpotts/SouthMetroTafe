using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class MyQueue
    {
        private int numItems;
        private int maxSize;
        private int front;
        private int rear;
        private string[] items;

        public MyQueue(int size)
        {
            maxSize = size;
            items = new string[maxSize];
            front = 0;
            rear = -1;
            numItems = 0;

        }

        // assumes the queue is NOT full
        public void Insert(string item)
        {
            if (rear == maxSize - 1)
            {
                rear = -1;
            }

            items[++rear] = item;
            numItems++;    
        }

        //assumes the queue is not empty
        public String Remove()
        {
            string item = items[front++];
            if(front == maxSize)
            {
                front = 0;
            }
            numItems--;
            return item;
        }

        public bool isFull()
        {
            return (numItems == maxSize);
        }

        public bool isEmpty()
        {
            return (numItems == 0);
        }

    }
}
