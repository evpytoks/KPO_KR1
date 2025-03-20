using System;
namespace KPO_KR;

class CreateBankAccountCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите название нового счёта:");
        String name = ConsoleWork.Instance.EnterString();
        Console.WriteLine($"ID вашего счёта: {Bank.Instance.CreateBankAccount(name)}");
    }
}

