using System;

namespace ConsoleApp7
{
    public static class CLI
    {
        public static void SetProject(House house)
        {
            int basement, walls, door, window, roof;
            Console.WriteLine("Проект дома. Введите количество:");
            Console.Write("Фундамент - ");
            basement = Convert.ToInt32(Console.ReadLine());
            Console.Write("Стены - ");
            walls = Convert.ToInt32(Console.ReadLine());
            Console.Write("Дверь - ");
            door = Convert.ToInt32(Console.ReadLine());
            Console.Write("Окно - ");
            window = Convert.ToInt32(Console.ReadLine());
            Console.Write("Крыша - ");
            roof = Convert.ToInt32(Console.ReadLine());
            house.SetHouse(basement, walls, door, window, roof);
        }
        
        public static void PrintHouse(House house)
        {
            Console.WriteLine($"Проект дома:");
            Console.WriteLine($"Фундамент - {house.GetBasement()} шт.");
            Console.WriteLine($"Стены - {house.GetWalls()} шт.");
            Console.WriteLine($"Дверь - {house.GetDoor()} шт.");
            Console.WriteLine($"Окно - {house.GetWindow()} шт.");
            Console.WriteLine($"Крыша - {house.GetRoof()} шт.");
        }
    }
}