using OOSE.W6.Restaurant;

var cooks = new List<ICook>()
{
    new HardRockCook(),
    new SimpleCook(),
    new SoccerCook()
};

cooks.ForEach(cook => Console.WriteLine($"{cook.GetType()}: {cook.Prepare()}"));
