using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод числа от пользователя
            Console.Write("Введите число: ");
            int userInput = int.Parse(Console.ReadLine());

            // Проверка, делится ли число на 3 и 7
            if (userInput % 3 == 0 && userInput % 7 == 0)
            {
                Console.WriteLine("Число делится и на 3, и на 7.");
            }
            else
            {
                Console.WriteLine("Число не делится одновременно на 3 и 7.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите целое число.");
        }
        catch (Exception ex) { 
       } 
    }
}