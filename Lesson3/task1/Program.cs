using Lesson2_bank;

List<BankAccount> list = new List<BankAccount>();

for (int i = 0;i<2;i++)
{
    typesOfBankAccount type = Reader.ReadType();
    decimal balance = Reader.ReadBalance();

    BankAccount bankAccount = new BankAccount(type, balance);
    list.Add(bankAccount);
    Console.WriteLine("Номер счета:" + bankAccount.GetID().ToString() + "\tТип счета:" + bankAccount.GetType().ToString() + "\tБалланс счета:" + bankAccount.GetBalance().ToString());
}
list[0].TransferTo(list[1].ID, 500);


