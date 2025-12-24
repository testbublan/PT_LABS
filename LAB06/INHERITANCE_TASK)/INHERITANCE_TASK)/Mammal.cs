using INHERITANCE_TASK;

public class Mammal : Animal
{
    public bool HasFur { get; set; }

    public Mammal(string species, int age, double weight, string habitat, bool isPredator, bool hasFur)
        : base(species, age, weight, habitat, isPredator)
    {
        HasFur = hasFur;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Species} издает характерный для млекопитающего звук.");
    }
}
