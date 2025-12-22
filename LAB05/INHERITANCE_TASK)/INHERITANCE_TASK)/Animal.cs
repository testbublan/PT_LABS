namespace INHERITANCE_TASK;

public abstract class Animal
{
    public string Species { get; set; }       // вид
    public int Age { get; set; }             // возраст
    public double Weight { get; set; }       // вес
    public string Habitat { get; set; }      // среда обитания
    public bool IsPredator { get; set; }     // хищник или нет

    protected Animal(string species, int age, double weight, string habitat, bool isPredator)
    {
        Species = species;
        Age = age;
        Weight = weight;
        Habitat = habitat;
        IsPredator = isPredator;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Species} издает звук.");
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Species} двигается.");
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Species} ест.");
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {Species}, age={Age}, weight={Weight}, habitat={Habitat}, predator={IsPredator}";
    }
}