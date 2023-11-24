using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        try
        {
            while (true)
            {
                // Ввод числа от пользователя
                Console.Write("Введите число (для завершения введите 0): ");
                int userInput = int.Parse(Console.ReadLine());

                // Проверка на ноль для завершения ввода
                if (userInput == 0)
                {
                    break;
                }

                // Прибавление числа к сумме
                sum += userInput;
            }

            // Вывод суммы
            Console.WriteLine($"Сумма введенных чисел: {sum}");
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