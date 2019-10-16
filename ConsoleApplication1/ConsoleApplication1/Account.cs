using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Account
    {
        int money = Convert.ToInt32(Console.ReadLine());
        public Account(int amount)
        {
            money = amount;
            Console.WriteLine("account");
            Console.WriteLine("Deposit");
            Console.WriteLine("withdrawal");
            Console.WriteLine("Balance");
        }
        public void Withdrawals(int amount)
        {
             money -= amount;
        }
        public void Deposit(int amount)
        {
            money += amount;
        }
        public int Balance()
        {
            return money;
        }
    }
}
