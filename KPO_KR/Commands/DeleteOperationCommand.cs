using System;
namespace KPO_KR;

class DeleteOperationCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите ID удаляемой операции.");
        int id = ConsoleWork.Instance.EnterANaturalNumber();
        try
        {
            Bank.Instance.DeleteOperation(id);
            ConsoleWork.Instance.ShowMessageSuccess();
        }
        catch (Exception ex)
        {
            ConsoleWork.Instance.ShowMessageFail();
        }
    }
}
