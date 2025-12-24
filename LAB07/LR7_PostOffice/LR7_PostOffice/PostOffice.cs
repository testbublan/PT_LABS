using System;
using System.Collections.Generic;
using System.Linq;

namespace LR7_PostOffice;

public class PostOffice
{
    public List<Package> Packages { get; } = new();

    // Прием посылки
    public void ReceivePackage(Package p)
    {
        if (p == null) throw new ArgumentNullException(nameof(p));

        // запрет: без отправителя/получателя
        if (string.IsNullOrWhiteSpace(p.Sender) || string.IsNullOrWhiteSpace(p.Receiver))
            throw new ArgumentException("Package must have Sender and Receiver");

        Packages.Add(p);
    }

    // Отправка самой старой (по SentDate)
    public void SendPackage()
    {
        if (Packages.Count == 0)
        {
            Console.WriteLine("No packages to send.");
            return;
        }

        Package oldest = Packages.OrderBy(x => x.SentDate).First();
        Packages.Remove(oldest);

        Console.WriteLine($"Sent: {oldest}");
    }

    public double CalculateAvgPackageCost()
    {
        if (Packages.Count == 0) return 0;
        return Packages.Average(p => p.Cost);
    }

    public override string ToString()
    {
        // сортировка по типу посылки (название класса)
        var sorted = Packages.OrderBy(p => p.GetType().Name).ToList();

        if (sorted.Count == 0) return "PostOffice: (empty)";

        return "PostOffice packages:\n" + string.Join("\n", sorted.Select(p => p.ToString()));
    }

    public static bool operator ==(PostOffice a, PostOffice b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.Packages.Sum(p => p.Cost).Equals(b.Packages.Sum(p => p.Cost));
    }

    public static bool operator !=(PostOffice a, PostOffice b) => !(a == b);

    public override bool Equals(object? obj)
        => obj is PostOffice other && this == other;

    public override int GetHashCode()
        => Packages.Sum(p => p.Cost).GetHashCode();
}