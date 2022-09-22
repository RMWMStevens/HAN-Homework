namespace OOSE.W4.FizzBuzz_TTD.Exercises
{
    public class PlayerExercise
    {
        readonly INameGenerator nameGenerator;
        readonly List<Player> players = new();

        public List<Player> Players { get => players; }

        public PlayerExercise(INameGenerator nameGenerator)
        {
            this.nameGenerator = nameGenerator;
        }

        public void AddRandomPlayer()
        {
            players.Add(new Player(nameGenerator.GenerateRandomName()));
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }

    public interface INameGenerator
    {
        string GenerateRandomName();
    }

    public class NameGenerator : INameGenerator
    {
        public string GenerateRandomName() => new Guid().ToString();
    }
}
