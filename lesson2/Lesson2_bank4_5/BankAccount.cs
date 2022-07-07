using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_bank
{
    public enum typesOfBankAccount
    {
        savingsAccounts,
        checkingAccounts,
        moneyMarketAccounts,
        certificatesOfDeposit,
        retirementAccounts,
        defaultType=-1
    }
    public class BankAccount
    {
        static int _lastNumber=99999;
        int _id;
        decimal _balance;
        typesOfBankAccount _type;

        public BankAccount(typesOfBankAccount type,decimal balance)
        {
            SetID();
            _type = type;
            _balance = balance;
        }

        private void SetID()
        {
            _id = ++_lastNumber;
            Console.WriteLine("Присвоен номер счета:" + _id);
        }

        

        
        public int GetID()
        {
            return _id;
        }
        public typesOfBankAccount GetType()
        {
            return _type;
        }
        public decimal GetBalance()
        {
            return _balance;
        }

    }
}
