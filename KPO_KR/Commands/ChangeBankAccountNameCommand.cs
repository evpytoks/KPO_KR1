using System;
namespace KPO_KR;

class ChangeBankAccountNameCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите ID изменяемого счёта:");
        int id = ConsoleWork.Instance.EnterANaturalNumber();
        Console.WriteLine("Введите новое название счёта:");
        String name = ConsoleWork.Instance.EnterString();
        try
        {
            Bank.Instance.ChangeBankAccountName(id, name);
            ConsoleWork.Instance.ShowMessageSuccess();
        }
        catch (Exception ex)
        {
            ConsoleWork.Instance.ShowMessageFail();
        }
    }
}
