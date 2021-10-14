using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.AccountNumber = 2334455667788112233;
            account.Balance = 50000;
            account.Type = AccountType.Credit;
            Console.WriteLine(account);
        }
    }
}
