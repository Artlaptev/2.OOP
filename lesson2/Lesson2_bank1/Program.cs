using Lesson2_bank;

BankAccount bankAccount = new BankAccount();
bankAccount.SetID();
bankAccount.SetType();
bankAccount.SetBalance();

Console.WriteLine("Номер счета:"+bankAccount.GetID().ToString()+ "\tТип счета:" + bankAccount.GetType().ToString()+ "\tБалланс счета:"+bankAccount.GetBalance().ToString());