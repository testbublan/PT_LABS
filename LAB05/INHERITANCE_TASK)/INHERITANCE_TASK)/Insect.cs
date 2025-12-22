using INHERITANCE_TASK;

public class Insect : Animal
{
    public int LegsCount { get; set; }

    public Insect(string species, int age, double weight, string habitat, bool isPredator, int legsCount)
        : base(species, age, weight, habitat, isPredator)
    {
        LegsCount = legsCount;
    }

    public override void Move()
    {
        Console.WriteLine($"{Species} ползет/летает.");
    }
}
