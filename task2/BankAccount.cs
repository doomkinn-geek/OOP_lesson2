using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    enum AccountType
    {
        Current, //текущий
        Checking, //расчетный
        Credit, //кредитный        
        Deposit, //депозитный
        Social //социальный
    }
    class BankAccount
    {
        public long GetAccountNumber()
        {
            return _accountNumber;
        }
        public void SetAccountNumber(long number)
        {
            _accountNumber = number;
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void SetBalance(decimal value)
        {
            _balance = value;
        }
        public AccountType GetAccountType()
        {
            return _type;
        }

        public void SetType(AccountType type)
        {
            _type = type;
        }
        private long _accountNumber;
        private decimal _balance;
        private AccountType _type;

        private static long _baseAccountNumber = 11111111111111;
        public override string ToString() => $"Номер счета - {GetAccountNumber()}, Баланс - {GetBalance()}, Тип счета - {GetAccountType()}";
        private long GenerateAccountNumber()
        {
            return _baseAccountNumber++;
        }

        public BankAccount()
        {
            SetAccountNumber(GenerateAccountNumber());
            SetBalance(0);
        }        
    }
}
