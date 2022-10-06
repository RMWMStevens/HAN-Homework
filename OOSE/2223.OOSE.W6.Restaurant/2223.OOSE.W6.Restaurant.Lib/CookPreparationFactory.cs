namespace OOSE.W6.Restaurant.Lib;

public static class CookPreparationFactory
{
    public static Preparation CreateCookPreparation(string preparationType)
        => (Preparation)Activator.CreateInstance(Type.GetType("OOSE.W6.Restaurant.Lib." + preparationType + "Preparation"));
}
