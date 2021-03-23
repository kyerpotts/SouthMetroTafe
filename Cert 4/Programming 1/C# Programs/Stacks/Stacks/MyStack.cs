using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class MyStack
    {
        private int maxSize;
        private int top;
        private String[] items;

        public MyStack(int size)
        {
            maxSize = size;
            items = new string[maxSize];
            top = -1;
        }

        public void Push (string item)
        {
            items[++top] = item;
        }

        public string Pop()
        {
            return items[top--];
        }

        public string Peek()
        {
            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool IsFull()

        {
            return top == maxSize - 1;
        }


    }
}
