using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1, b2, b3, b4;
            b1 = new BankAccount();
            b2 = new BankAccount(AccountType.Credit);
            b3 = new BankAccount(50000);
            b4 = new BankAccount(100000,AccountType.Deposit);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
        }
    }
}
