using System;

namespace ConsoleApp7
{
    public static class CLI
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************");
            Console.WriteLine("Строительство дома");
            Console.WriteLine("******************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Проект дома. Введите количество:");
        }
        
        public static int SetValue(string message)
        {
            int temp;
            do
            {
                Console.Write(message);
                temp = Convert.ToInt32(Console.ReadLine());
                if (temp <= 0)
                {
                    Console.WriteLine("Количество не может быть меньше или равно 0!!!");
                }
            } while (temp <= 0);
            return temp;
        }

        public static void Building(House house, Team worker)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Осталось построить:");
            PrintHouse(house);
            Console.ResetColor();
            Console.WriteLine("Выберите часть дома, которую будем строить:");
            Console.WriteLine("1 - фундамент, 2 - стены, 3 - дверь, 4 - окно, 5 - крыша");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    house.Basement = CheckBuilding(house.Basement, worker, "закончил строительство 1 фундамента");
                    break;
                case 2:
                    house.Walls = CheckBuilding(house.Walls, worker, "закончил строительство 1 стены");
                    break;
                case 3:
                    house.Door = CheckBuilding(house.Door, worker, "закончил установку 1 двери");
                    break;
                case 4:
                    house.Window = CheckBuilding(house.Window, worker, "закончил установку 1 окна");
                    break;
                case 5:
                    house.Roof = CheckBuilding(house.Roof, worker, "закончил строительство 1 крыши");
                    break;
                default:
                    Console.WriteLine("Вы ввели неверное значение!!!");
                    break;
            }
        }
        
        private static int CheckBuilding(int value, Team worker, string message)
        {
            int temp = value;
            if (temp - 1 >= 0)
            {
                temp -= 1;
                Console.WriteLine($"{worker.Position} {worker.Name} {message}");
            }
            else
            {
                Console.WriteLine("Уже построено!!!");
            }
            return temp;
        }
        
        private static void PrintHouse(House house)
        {
            Console.WriteLine($"Фундамент - {house.Basement} шт.");
            Console.WriteLine($"Стены - {house.Walls} шт.");
            Console.WriteLine($"Дверь - {house.Door} шт.");
            Console.WriteLine($"Окно - {house.Window} шт.");
            Console.WriteLine($"Крыша - {house.Roof} шт.");
        }

        public static void PrintReport(House house1, House house2, Team worker)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\tОТЧЕТ:");
            Console.WriteLine("\t\tПроект:   Уже построено:   Осталось построить:");
            Console.WriteLine($"Фундамент - \t{house1.Basement}\t\t{house1.Basement - house2.Basement}\t\t{house2.Basement}");
            Console.WriteLine($"Стены     - \t{house1.Walls}\t\t{house1.Walls - house2.Walls}\t\t{house2.Walls}");
            Console.WriteLine($"Дверь     - \t{house1.Door}\t\t{house1.Door - house2.Door}\t\t{house2.Door}");
            Console.WriteLine($"Окно      - \t{house1.Window}\t\t{house1.Window - house2.Window}\t\t{house2.Window}");
            Console.WriteLine($"Крыша     - \t{house1.Roof}\t\t{house1.Roof - house2.Roof}\t\t{house2.Roof}");
            Console.WriteLine($"Отчет предоставил {worker.Position} {worker.Name}");
            Console.ResetColor();
        }
    }
}