using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0, AccountType.Deposit);
            Console.WriteLine(account);
            account.IncreaseBalance(50000);
            Console.WriteLine(account);
            account.GetMoney(10000);
            Console.WriteLine(account);
            account.GetMoney(50000);
            Console.WriteLine(account);
        }
    }
}
