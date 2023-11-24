using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод первого числа от пользователя
            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());

            // Ввод второго числа от пользователя
            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Сравнение чисел и вывод результата
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} больше {secondNumber}.");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{secondNumber} больше {firstNumber}.");
            }
            else
            {
                Console.WriteLine("Числа равны.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите целое число.");
        }
       
       
            
        
    }
}