using System;

namespace 29_09_2021_question2
{
    class Bank_account
    {
        int min_balance, balance1;
        public Bank_account(int balance1)
        {
            min_balance = 500;
            this.balance1 = balance1;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the balance:");
            int bal = Convert.ToInt32(Console.ReadLine());
            Bank_account balance = new Bank_account(bal);
            Console.WriteLine("default_balance=" + balance.min_balance);
            Console.WriteLine("new_balance=" + balance.balance1);
        }
    }
}
