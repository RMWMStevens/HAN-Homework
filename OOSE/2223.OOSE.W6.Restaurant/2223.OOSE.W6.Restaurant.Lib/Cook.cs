using System.Text;

namespace OOSE.W6.Restaurant.Lib;

public class Cook
{
    public string Name { get; private set; }

    public Preparation Preparation { get; private set; }

    public bool Prepared { get; private set; }

    public Cook(string name, Preparation preparation)
    {
        Name = name;
        Preparation = preparation;
    }

    public string Prepare()
    {
        var sb = new StringBuilder();
        Preparation.Steps.ForEach(step => sb.Append(step + "\n"));
        return sb.ToString();
    }
}