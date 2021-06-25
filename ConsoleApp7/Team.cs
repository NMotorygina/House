namespace ConsoleApp7
{
    public class Team : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        
        public Team() {}
        
        public Team(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}