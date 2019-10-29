using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Queue
    {
        private int[] space;
        //vi tri dau tien
        private int num = 0;
        //vi tri cuoi cung
        private int queue = -1;
        private int count = 0;

 
        public Queue(int number)
        {
            space = new int[number];
            ////num = 0;
            ////queue = -1;
            ////count = 0;
        }

        public void Enqueue(int numb)
        {
            space[num++] = numb;
            count++;
        }
        public int Dequeue()
        {
            int x = space[num];
            for (int i = num; i < queue; i++)
            {// move num to next position
                space[i] = space[i + 1];
            }
            //tr lai vi tri cuoi cung
            queue--;
            // 
            count--;
            return x;
        }
        public int Count()
        {
            return count;
        }
        public int peek()
        {
            int a = space[num];
            for (int i = num; i < queue; i++)
                space[i] = space[i + 1];
            return a;
        }
    }
}
