using System;
namespace KPO_KR;

class DeleteBankAccountCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите ID удаляемого счёта:");
        int id = ConsoleWork.Instance.EnterANaturalNumber();
        try
        {
            Bank.Instance.DeleteBankAccount(id);
            ConsoleWork.Instance.ShowMessageSuccess();
        }
        catch (Exception ex)
        {
            ConsoleWork.Instance.ShowMessageFail();
        }
    }
}


