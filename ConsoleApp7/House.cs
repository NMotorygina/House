using System;

namespace ConsoleApp7
{
    public class House
    {
        private int Basement { get; set; }
        private int Walls { get; set; }
        private int Door { get; set; }
        private int Window { get; set; }
        private int Roof { get; set; }

        public void SetBasement(int basement)
        {
            if (basement < 0)
            {
                Console.WriteLine("Количество не может быть меньше 0!!!");
            }
            else
            {
                Basement = basement;
            }
        }
        
        public void SetWalls(int walls)
        {
            if (walls < 0)
            {
                Console.WriteLine("Количество не может быть меньше 0!!!");
            }
            else
            {
                Walls = walls;
            }
        }
        
        public void SetDoor(int door)
        {
            if (door < 0)
            {
                Console.WriteLine("Количество не может быть меньше 0!!!");
            }
            else
            {
                Door = door;;
            }
        }
        
        public void SetWindow(int window)
        {
            if (window < 0)
            {
                Console.WriteLine("Количество не может быть меньше 0!!!");
            }
            else
            {
                Window = window;
            }
        }
        
        public void SetRoof(int roof)
        {
            if (roof < 0)
            {
                Console.WriteLine("Количество не может быть меньше 0!!!");
            }
            else
            {
                Roof = roof;
            }
        }

        public int GetBasement()
        {
            return Basement;
        }
        
        public int GetWalls()
        {
            return Walls;
        }
        
        public int GetDoor()
        {
            return Door;
        }
        
        public int GetWindow()
        {
            return Window;
        }
        
        public int GetRoof()
        {
            return Roof;
        }
    }
}