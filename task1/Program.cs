using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.SetAccountNumber(2334455667788112233);
            account.SetBalance(50000);
            account.SetType(AccountType.Credit);
            Console.WriteLine(account);
        }
    }
}
