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
        retirementAccounts
    }
    public class BankAccount
    {
        static int _lastNumber=99999;
        int _id;
        decimal _balance;
        typesOfBankAccount _type;

        public void SetID()
        {
            _id = ++_lastNumber;
            Console.WriteLine("Присвоен номер счета:" + _id);
        }

        public void SetType()
        {

            bool flag = true;
            while (flag)
            {
                
                Console.WriteLine("Введите порядковый номер типа счета из предлоденных вариантов:\n" + "1.Savings accounts\n 2.Checking accounts\n 3.Money market accounts\n 4.Certificates of deposit(CDs)\n 5.Retirement accounts");
                string typeN = Console.ReadLine();
                if (int.TryParse(typeN, out int typeNint) && typeNint <= 5&& typeNint>=1)
                {
                    switch (typeN)
                    {
                        case "1":
                            _type = typesOfBankAccount.savingsAccounts;
                            break;
                        case "2":
                            _type = typesOfBankAccount.checkingAccounts;
                            break;
                        case "3":
                            _type = typesOfBankAccount.moneyMarketAccounts;
                            break;
                        case "4":
                            _type = typesOfBankAccount.certificatesOfDeposit;
                            break;
                        case "5":
                            _type = typesOfBankAccount.retirementAccounts;
                            break;
                    }
                    flag = false;
                }
            }
                 
        }
        public void SetBalance()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите баланс:");
                if (!decimal.TryParse(Console.ReadLine(), out decimal balance))
                {
                    Console.WriteLine("неверный формат");
                    continue;
                }
                _balance = balance;
                flag = false;
            }
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
