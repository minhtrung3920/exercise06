using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack(10);
            stack.push(5);
            stack.push(4);
            stack.push(6);

            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.peek());


            ////string[] array = { "pham", "ngoc", "duy" };
            //////lay phan tu bo vao stack, tao vong for cho vao do.

            ////for (int i = 0; i < array.Length; i++)
            ////{
            ////    Console.Write(array[i] + " ");

            ////}

        }
    }
}
