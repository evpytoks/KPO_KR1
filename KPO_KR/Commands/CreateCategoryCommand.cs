using System;
namespace KPO_KR;

class CreateCategoryCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите название категории:");
        String name = ConsoleWork.Instance.EnterString();
        Console.WriteLine("Введите 1, если эта категория является доходом и 2, если расходом:");
        int categoryType = ConsoleWork.Instance.EnterANaturalNumber(3);
        Console.WriteLine($"ID новой категории: {Bank.Instance.CreateCategory(name, (OperationType)categoryType)}");
    }
}
