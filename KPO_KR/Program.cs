using System;
using System.Xml.Linq;

namespace KPO_KR;

internal class Program
{
    static Dictionary<int, ICommand> commands = new()
    {
        { 1, new CreateBankAccountCommand() },
        { 2, new ChangeBankAccountNameCommand() },
        { 3, new DeleteBankAccountCommand() },
        { 4, new CreateCategoryCommand() },
        { 5, new ChangeCategoryNameCommand() },
        { 6, new DeleteCategoryCommand() },
        { 7, new CreateOperationCommand() },
        { 8, new ChangeOperationDescriptionCommand() },
        { 9, new DeleteOperationCommand() }
    };

    static void Main()
    {
        int operation = -1;

        while (operation != 10)
        {
            Console.WriteLine("Выберите желаемую операцию:");
            Console.WriteLine("1. Открыть счёт.");
            Console.WriteLine("2. Редактировать название счёта.");
            Console.WriteLine("3. Закрыть счёт.");
            Console.WriteLine("4. Создать категорию.");
            Console.WriteLine("5. Редактировать название категории.");
            Console.WriteLine("6. Удалить категорию.");
            Console.WriteLine("7. Добавить денежную операцию.");
            Console.WriteLine("8. Редактировать описание денежной операции.");
            Console.WriteLine("9. Удалить денежную операцию.");
            Console.WriteLine("10. Выйти из программы.");
            operation = ConsoleWork.Instance.EnterANaturalNumber(11);

            if (commands.ContainsKey(operation))
            {
                commands[operation].Execute();
            }
        }
    }
}
