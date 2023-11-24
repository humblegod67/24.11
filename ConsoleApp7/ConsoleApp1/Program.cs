using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите количество чисел в последовательности Фибоначчи: ");
            int count = int.Parse(Console.ReadLine());
            if (count < 0)
            {
                Console.WriteLine("Ошибка: Введите неотрицательное количество чисел.");
                return;
            }
            int firstNumber = 1, secondNumber = 1;
            Console.Write($"{firstNumber} {secondNumber} ");
            int i = 2;
            while (i < count)
            {
                int nextNumber = firstNumber + secondNumber;
                Console.Write($"{nextNumber} ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                i++;
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