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
        private int num = 0;
        private int queue = -1;

 
        public Queue(int number)
        {
            space = new int[number];
        }

        public void Enqueue(int number)
        {
            space[num + 1] = number;
            queue++;
        }
        public int Dequeue()
        {
            return space[queue--];
            queue--;
        }
        public int count()
        {
            return queue + 1;
        }
        public int peek()
        {
            return space[queue];
        }
    }
}
