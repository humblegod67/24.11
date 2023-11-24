using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите первое целое число: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int minNumber = Math.Min(firstNumber, secondNumber);
            int maxNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine($"Целые числа между {minNumber} и {maxNumber}:");
            for (int i = minNumber; i <= maxNumber; i++)
            {
                Console.Write($"{i} ");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите целое число.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
