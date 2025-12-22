using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Тестирование класса QuadraticEquation ---");

        // --- Создание и проверка объектов ---
        Console.WriteLine("\n1. Создание объектов:");
        try
        {
            // Создание корректных объектов
            QuadraticEquation eq1 = new QuadraticEquation(1, -3, 2); // x^2 - 3x + 2 = 0
            QuadraticEquation eq2 = new QuadraticEquation(1, 0, 1); // x^2 + 1 = 0
            QuadraticEquation eq3 = new QuadraticEquation(1, -2, 1); // x^2 - 2x + 1 = 0

            eq1.PrintEquation();
            Console.WriteLine($"Количество корней: {eq1.GetRootsCount()}");
            double[] roots1 = eq1.GetRoots();
            Console.Write("Корни: ");
            foreach (double root in roots1) Console.Write($"{root:F2} ");
            Console.WriteLine();

            eq2.PrintEquation();
            Console.WriteLine($"Количество корней: {eq2.GetRootsCount()}");
            double[] roots2 = eq2.GetRoots();
            Console.Write("Корни: ");
            foreach (double root in roots2) Console.Write($"{root:F2} ");
            Console.WriteLine();

            eq3.PrintEquation();
            Console.WriteLine($"Количество корней: {eq3.GetRootsCount()}");
            double[] roots3 = eq3.GetRoots();
            Console.Write("Корни: ");
            foreach (double root in roots3) Console.Write($"{root:F2} ");
            Console.WriteLine();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка при создании объектов: {ex.Message}");
        }

        // --- Проверка валидации при создании (коэффициент a = 0) ---
        Console.WriteLine("\n2. Проверка валидации (a = 0):");
        try
        {
            QuadraticEquation invalidEq = new QuadraticEquation(0, 1, 1); // Должна возникнуть ошибка
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка при создании уравнения с a=0: {ex.Message}");
        }

        // --- Проверка валидации при изменении свойства (после создания) ---
        Console.WriteLine("\n3. Проверка валидации при изменении свойства A:");
        QuadraticEquation eq4 = new QuadraticEquation(2, 3, 1);
        eq4.PrintEquation();

        Console.WriteLine("Попытка изменить A на 0:");
        try
        {
            eq4.A = 0; // Должна возникнуть ошибка
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка при изменении A на 0: {ex.Message}");
        }
        Console.WriteLine("A после ошибки:");
        eq4.PrintEquation(); // A не должен измениться

        Console.WriteLine("\n--- Тестирование завершено ---");
    }
}