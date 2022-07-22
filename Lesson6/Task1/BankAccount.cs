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
        defaultType = -1
    }
    public class BankAccount
    {
        static int _lastNumber = 99999;
        static List<BankAccount> __users = new List<BankAccount>();
        public int ID { get; private set; }
        public decimal Balance { get; private set; }
        typesOfBankAccount _type;

        public BankAccount(typesOfBankAccount type, decimal balance)
        {
            SetID();
            _type = type;
            Balance = balance;
            __users.Add(this);
        }

        private void SetID()
        {
            ID = ++_lastNumber;
            Console.WriteLine("Присвоен номер счета:" + ID);
        }

        public int GetID()
        {
            return ID;
        }
        public typesOfBankAccount GetType()
        {
            return _type;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public bool TransferTo(int receiver, decimal amount)
        {
            bool flag = false;
            if (this.Balance < amount) return flag;
            foreach (BankAccount bankAccount in __users)
            {
                if (bankAccount.ID != receiver) continue;
                bankAccount.Balance += amount;
                flag = true;
                return flag;
            }
            return flag;
        }
        public static void Transfer(BankAccount from, BankAccount to, decimal amount)
        {
            if (from.Balance < amount&&amount<0) return;
            from.Balance -= amount;
            to.Balance += amount;
        }

    }
}
