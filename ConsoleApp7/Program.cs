using static ConsoleApp7.CLI;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            var house = new House();
            SetProject(house);
            
            PrintHouse(house);
            
            
        }
    }
}