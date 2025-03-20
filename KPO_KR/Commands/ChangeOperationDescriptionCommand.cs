using System;
namespace KPO_KR;

class ChangeOperationDescriptionCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите ID изменяемой операции:");
        int id = ConsoleWork.Instance.EnterANaturalNumber();
        Console.WriteLine("Введите новое описание операции:");
        String name = ConsoleWork.Instance.EnterString();
        try
        {
            Bank.Instance.ChangeOperationDescription(id, name);
            ConsoleWork.Instance.ShowMessageSuccess();
        }
        catch (Exception ex)
        {
            ConsoleWork.Instance.ShowMessageFail();
        }
    }
}

