using System;
using static ConsoleApp7.CLI;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Start();
            int basement, walls, door, window, roof;
            basement = SetValue("Фундамент - ");
            walls = SetValue("Стены - ");
            door = SetValue("Дверь - ");
            window = SetValue("Окно - ");
            roof = SetValue("Крыша - ");
            var house = new House(basement, walls, door, window, roof);
            var tempHouse = new House(basement, walls, door, window, roof);
            var worker = new Team("Иван", "Рабочий");
            var teamLeader = new Team("Петр", "Бригадир");
            Console.WriteLine("Для строительства дома понадобятся 2 человека - рабочий и бригадир");
            do
            {
                Console.WriteLine("Выберите дальнейшее действие: 1 - строить, 2 - посмотреть отчет");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Building(tempHouse, worker);
                        break;
                    case 2:
                        PrintReport(house, tempHouse, teamLeader);
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное значение!!!");
                        break;
                }
            } while (tempHouse.Basement != 0 || tempHouse.Walls != 0 || tempHouse.Door != 0 ||
                     tempHouse.Window != 0 || tempHouse.Roof != 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Строительство дома завершено !!!");
            Console.WriteLine("             *");
            Console.WriteLine("           *    *");
            Console.WriteLine("        ------------");
            Console.WriteLine("        |           |");
            Console.WriteLine("        |    дом    |");
            Console.WriteLine("        ------------");
            Console.ResetColor();
        }
    }
}