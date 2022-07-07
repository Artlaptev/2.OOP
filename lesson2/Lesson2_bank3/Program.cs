using Lesson2_bank;

typesOfBankAccount type = Reader.ReadType();
decimal balance=Reader.ReadBalance();

BankAccount bankAccount = new BankAccount(type,balance);

Console.WriteLine("Номер счета:"+bankAccount.GetID().ToString()+ "\tТип счета:" + bankAccount.GetType().ToString()+ "\tБалланс счета:"+bankAccount.GetBalance().ToString());