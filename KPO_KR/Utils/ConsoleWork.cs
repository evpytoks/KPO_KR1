using System;
namespace KPO_KR;

public class ConsoleWork
{
    private static readonly Lazy<ConsoleWork> instance = new Lazy<ConsoleWork>(() => new ConsoleWork());

    public static ConsoleWork Instance => instance.Value;

    public int EnterANaturalNumber(int number)
    {
        int enteredNumber;
        while (!int.TryParse(Console.ReadLine(), out enteredNumber) || enteredNumber >= number || enteredNumber <= 0)
        {
            Console.WriteLine($"Ошибка! Введите корректное целое число от 1 до {number - 1} включительно: ");
        }

        return enteredNumber;
    }

    public int EnterANaturalNumber()
    {
        int enteredNumber;
        while (!int.TryParse(Console.ReadLine(), out enteredNumber) || enteredNumber <= 0)
        {
            Console.WriteLine($"Ошибка! Введите корректное натурально число: ");
        }

        return enteredNumber;
    }


    public String EnterString()
    {
        string enteredString = "";

        while (string.IsNullOrWhiteSpace(enteredString))
        {
            Console.Write("Введите строку: ");
            enteredString = Console.ReadLine();
        }

        return enteredString;
    }

    public void ShowMessageSuccess()
    {
        Console.WriteLine("Успешно!");
    }

    public void ShowMessageFail()
    {
        Console.WriteLine("Ошибка. Не удалось совершить операцию, повторите попытку.");
    }
}

