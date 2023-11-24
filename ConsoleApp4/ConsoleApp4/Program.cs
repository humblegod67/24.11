using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите число от 1 до 7: ");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка: Введено некорректное значение.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите числовое значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}