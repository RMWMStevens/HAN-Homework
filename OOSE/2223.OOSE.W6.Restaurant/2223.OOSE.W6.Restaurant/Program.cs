using OOSE.W6.Restaurant.Lib;

var cooks = new List<Cook>()
{
    new Cook("Harry", CookPreparationFactory.CreateCookPreparation("HardRock")),
    new Cook("Sally", CookPreparationFactory.CreateCookPreparation("Simple")),
    new Cook("Sonny", CookPreparationFactory.CreateCookPreparation("Soccer"))
};

cooks.ForEach(cook => Console.WriteLine($"{cook.GetType()}: {cook.Prepare()}"));

cooks.RemoveAll(_ => _.Preparation.GetType() == typeof(HardRockPreparation));

cooks.Add(new Cook("Silly", CookPreparationFactory.CreateCookPreparation("Soccer")));

cooks.ForEach(cook => Console.WriteLine($"{cook.GetType()}: {cook.Prepare()}"));
