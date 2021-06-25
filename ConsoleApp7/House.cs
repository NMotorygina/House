namespace ConsoleApp7
{
    public class House : IPart
    {
        public int Basement { get; set; }
        public int Walls { get; set; }
        public int Door { get; set; }
        public int Window { get; set; }
        public int Roof { get; set; }
        
        public House() {}
        
        public House(int basement, int walls, int door, int window, int roof)
        {
            Basement = basement;
            Walls = walls;
            Door = door;
            Window = window;
            Roof = roof;
        }
    }
}