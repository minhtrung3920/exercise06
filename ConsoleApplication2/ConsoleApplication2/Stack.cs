using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Stack
    {
        private int size = 5;
        private int top = -1;
        private int[] buffer;
        public Stack(int Size)
        {
            buffer = new int[size];

        }
        public void push(int number)
        {
            /// 
            buffer[top + 1] = number;
            top++;
        }
        public int pop()
        {
            //Get next item from stack

            //Console.WriteLine("nhap number");
            //int n = Convert.ToInt32(Console.ReadLine());

            ////int temp = top;
            ////top--;

            return buffer[top--];

        }
        public int count()
        {
            //Get the number of items
            return top + 1;
        }
        public int peek()
        {
            //Get the number of items
            return buffer[top];
        }
        public void clear()
        {
            top = -1;
        }
    }
}
