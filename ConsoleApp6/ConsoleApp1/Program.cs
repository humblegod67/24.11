using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Ошибка: Введите положительное значение n.");
                return;
            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма четных чисел от 2 до {2 * n}: {sum}");
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