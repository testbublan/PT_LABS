using System;

namespace LR7_PostOffice;

public class Box : Package, IUrgent
{
    public double WeightKg { get; set; }        // вес посылки
    public bool IsUrgent { get; set; }
    public double AdditionalCost { get; }

    public Box(
        string sender,
        string receiver,
        DateTime sentDate,
        double baseCost,
        double weightKg,
        bool isUrgent,
        double additionalCost = 5.00)
        : base(sender, receiver, sentDate, baseCost)
    {
        if (weightKg <= 0) throw new ArgumentException("Weight must be > 0");
        WeightKg = weightKg;

        IsUrgent = isUrgent;
        AdditionalCost = additionalCost;

        // пример логики цены: доплата за вес (1.20 за кг)
        AddCost(WeightKg * 1.20);

        // срочность
        if (IsUrgent) AddCost(AdditionalCost);
    }
}