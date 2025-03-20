using System;
namespace KPO_KR;

class DeleteCategoryCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Введите ID удаляемой категории.");
        int id = ConsoleWork.Instance.EnterANaturalNumber();
        try
        {
            Bank.Instance.DeleteCategory(id);
            ConsoleWork.Instance.ShowMessageSuccess();
        }
        catch (Exception ex)
        {
            ConsoleWork.Instance.ShowMessageFail();
        }
    }
}
