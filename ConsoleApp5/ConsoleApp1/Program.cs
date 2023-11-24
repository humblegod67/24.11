using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите название дня недели: ");
            string dayName = Console.ReadLine().ToLower(); 
            switch (dayName)
            {
                case "понедельник":
                    Console.WriteLine("Порядковый номер дня: 1");
                    break;
                case "вторник":
                    Console.WriteLine("Порядковый номер дня: 2");
                    break;
                case "среда":
                    Console.WriteLine("Порядковый номер дня: 3");
                    break;
                case "четверг":
                    Console.WriteLine("Порядковый номер дня: 4");
                    break;
                case "пятница":
                    Console.WriteLine("Порядковый номер дня: 5");
                    break;
                case "суббота":
                    Console.WriteLine("Порядковый номер дня: 6");
                    break;
                case "воскресенье":
                    Console.WriteLine("Порядковый номер дня: 7");
                    break;
                default:
                    Console.WriteLine("Ошибка: Такого дня нет.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}