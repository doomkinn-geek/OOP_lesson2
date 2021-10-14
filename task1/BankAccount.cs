using System;
using System.Collections.Generic;
using System.Text;

namespace task1
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
        public long AccountNumber
        {
            get => _accountNumber;
            set { _accountNumber = value; }
        }
        public decimal Balance
        {
            get => _balance;
            set { _balance = value; }
        }
        public AccountType Type
        {
            get => _type;
            set { _type = value; }
        }
        private long _accountNumber;
        private decimal _balance;
        private AccountType _type;
        public override string ToString() => $"Номер счета - {AccountNumber}, Баланс - {Balance}, Тип счета - {Type}";        
    }
}
