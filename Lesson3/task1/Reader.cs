using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_bank
{
    public static class Reader
    {
        public static typesOfBankAccount ReadType()
        {
            typesOfBankAccount type=typesOfBankAccount.defaultType;
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Введите порядковый номер типа счета из предлоденных вариантов:\n" + "1.Savings accounts\n 2.Checking accounts\n 3.Money market accounts\n 4.Certificates of deposit(CDs)\n 5.Retirement accounts");
                string typeN = Console.ReadLine();
                if (int.TryParse(typeN, out int typeNint) && typeNint <= 5 && typeNint >= 1)
                {
                    switch (typeN)
                    {
                        case "1":
                            type = typesOfBankAccount.savingsAccounts;
                            break;
                        case "2":
                            type = typesOfBankAccount.checkingAccounts;
                            break;
                        case "3":
                            type = typesOfBankAccount.moneyMarketAccounts;
                            break;
                        case "4":
                            type = typesOfBankAccount.certificatesOfDeposit;
                            break;
                        case "5":
                            type = typesOfBankAccount.retirementAccounts;
                            break;
                    }
                    flag = false;
                }
            }
            return type;

        }
        public static decimal ReadBalance()
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
                return balance;
            }
            return -1;
        }
    }
}
