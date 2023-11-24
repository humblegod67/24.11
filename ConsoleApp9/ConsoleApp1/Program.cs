using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите количество чисел для суммирования: ");
            int count = int.Parse(Console.ReadLine());
            if (count < 0)
            {
                Console.WriteLine("Ошибка: Введите неотрицательное количество чисел.");
                return;
            }

            int sum = 0;
            int numbersFound = 0;
            int i = 1;
            Console.WriteLine($"Числа, удовлетворяющие критериям, и их сумма:");
            while (numbersFound < count)
            {
                if (i % 5 == 2 || i % 3 == 1)
                {
                    Console.Write($"{i} ");
                    sum += i;
                    numbersFound++;
                }
                i++;
            }
            Console.WriteLine($"\nСумма чисел: {sum}");
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