using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1, b2, b3, b4;
            b1 = new BankAccount();
            b2 = new BankAccount(AccountType.Social);
            b3 = new BankAccount(70000);
            b4 = new BankAccount(200000, AccountType.Checking);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
        }
    }
}
