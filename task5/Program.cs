using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0, AccountType.Deposit);
            Console.WriteLine(account);
            Console.WriteLine("Кладем на счет 50000");
            account.IncreaseBalance(50000);
            Console.WriteLine(account);
            Console.WriteLine("Снимаем 10000");
            account.GetMoney(10000);
            Console.WriteLine(account);
            Console.WriteLine("Снимаем 50000");
            account.GetMoney(50000);
            Console.WriteLine(account);
        }
    }
}
