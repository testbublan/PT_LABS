using INHERITANCE_TASK;

public class Reptile : Animal
{
    public bool IsVenomous { get; set; }

    public Reptile(string species, int age, double weight, string habitat, bool isPredator, bool isVenomous)
        : base(species, age, weight, habitat, isPredator)
    {
        IsVenomous = isVenomous;
    }

    public override void Move()
    {
        Console.WriteLine($"{Species} ползает.");
    }
}
