namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() 
            { 
                "Cyberpunk 2077", "Starfield", "Horizon: Zero Dawn", "Nier: Automata", "Hellblade: Senua's Sacrifice",
                "Stray", "Shadow of the Tomb Raider", "Horizon: Forbidden West", "The Maser's Pupil", "Final Fantasy VII", "Control Ultimate Edition"
            };

            videoGames.OrderBy(name => name.Length).ToList().ForEach(name => Console.WriteLine(name));

        }
    }
}
