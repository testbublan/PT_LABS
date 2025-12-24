using INHERITANCE_TASK;

Animal[] animals =
{
    new Bird("Орлан", 5, 4.5, "горы", true, 2.0),
    new Bird("Голубь", 2, 0.3, "город", false, 0.5),
    new Fish("Акула", 8, 350, "океан", true, true),
    new Fish("Карась", 1, 0.2, "река", false, false),
    new Insect("Муравей", 1, 0.0003, "лес", false, 6),
    new Insect("Скорпион", 3, 0.02, "пустыня", true, 8),
    new Mammal("Лев", 6, 190, "савана", true, true),
    new Mammal("Кролик", 1, 2.1, "поле", false, true),
    new Reptile("Кобра", 4, 5, "джунгли", true, true),
    new Reptile("Ящерица", 2, 0.1, "камни", false, false)
};

// вывод всех животных
foreach (var a in animals)
{
    Console.WriteLine(a);
    a.Move();
    a.Eat();
    a.MakeSound();
    Console.WriteLine();
}

// средний возраст хищников
var predators = animals.Where(a => a.IsPredator).ToList();
double avgPredatorAge = predators.Count == 0 ? 0 : predators.Average(a => a.Age);
Console.WriteLine($"Средний возраст хищников: {avgPredatorAge:F2}");

// самый тяжёлый хищник
var heaviestPredator = predators.OrderByDescending(a => a.Weight).FirstOrDefault();
if (heaviestPredator != null)
    Console.WriteLine($"Самый тяжелый хищник: {heaviestPredator}");