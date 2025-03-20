using System;
namespace KPO_KR;

class CreateOperationCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите ID счёта, где произошла операция:");
        int bankAccountId = ConsoleWork.Instance.EnterANaturalNumber();
        Console.WriteLine("Введите ID категории, к которой относится операция:");
        int categoryId = ConsoleWork.Instance.EnterANaturalNumber();
        Console.WriteLine("Введите сумму операции (должна быть положительной):");
        int amount = ConsoleWork.Instance.EnterANaturalNumber();
        Console.WriteLine("Введите дату операции:");
        String date = ConsoleWork.Instance.EnterString();
        Console.WriteLine("Введите описание операции:");
        String name = ConsoleWork.Instance.EnterString();
        try
        {
            Console.WriteLine($"ID новой операции: {Bank.Instance.CreateOperation(bankAccountId, categoryId, amount, date, name)}");
        }
        catch (Exception ex)
        {
            ConsoleWork.Instance.ShowMessageFail();
        }
    }
}
