using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenStack
{
    class GenericStack <T>
    {
        private int top;
        private int maxSize;
        private T[] items;

        public GenericStack(int size)
        {
            maxSize = size;
            top = -1;
            items = new T[maxSize];
        }

        public void Push (T item)
        {
            items[++top] = item;
        }

        public T Pop()
        {
            return items[top--];
        }

        public T Peek()
        {
            return items[top];
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
     }

}
