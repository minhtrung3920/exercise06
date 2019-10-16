using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create new Account:");
            int money = Convert.ToInt32(Console.ReadLine());
            Account user = new Account(money);
            Console.WriteLine("money: {0}", user.Balance());
            Console.WriteLine("1. Depsosit // 2. Withdraw");
            int choose = Convert.ToInt32(Console.ReadLine());

            if (userChoose(choose))
            {
                Console.WriteLine("money put in : ");
                int inMoney = Convert.ToInt32(Console.ReadLine());
                user.Deposit(inMoney);
            }
        }
        static bool userChoose(int choose)
        {
            return true;
        }
    }
    
}
