namespace OOSE.W4.FizzBuzz_TTD.Player
{
    public class PlayerExercise2
    {
        readonly NameGenerator2 nameGenerator;
        readonly List<Player2> players = new();

        public List<Player2> Players { get => players; }

        public PlayerExercise2(NameGenerator2 nameGenerator)
        {
            this.nameGenerator = nameGenerator;
        }

        public void AddRandomPlayer()
        {
            players.Add(new Player2(nameGenerator.GenerateRandomName()));
        }
    }

    public class Player2
    {
        public string Name { get; set; }

        public Player2(string name)
        {
            Name = name;
        }
    }

    public class NameGenerator2
    {
        public virtual string GenerateRandomName() => new Guid().ToString();
    }
}
