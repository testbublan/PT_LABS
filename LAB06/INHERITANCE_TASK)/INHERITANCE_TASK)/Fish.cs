using INHERITANCE_TASK;

public class Fish : Animal
{
    public bool IsSaltWater { get; set; }

    public Fish(string species, int age, double weight, string habitat, bool isPredator, bool isSaltWater)
        : base(species, age, weight, habitat, isPredator)
    {
        IsSaltWater = isSaltWater;
    }

    public override void Move()
    {
        Console.WriteLine($"{Species} плывет.");
    }
}
