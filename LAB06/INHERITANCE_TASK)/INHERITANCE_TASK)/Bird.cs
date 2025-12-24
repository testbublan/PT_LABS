namespace INHERITANCE_TASK;

public class Bird : Animal
{
    public double WingSpan { get; set; } // размах крыльев

    public Bird(string species, int age, double weight, string habitat, bool isPredator, double wingSpan)
        : base(species, age, weight, habitat, isPredator)
    {
        WingSpan = wingSpan;
    }

    public override void Move()
    {
        Console.WriteLine($"{Species} летит.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Species} поет/кричит.");
    }
}
