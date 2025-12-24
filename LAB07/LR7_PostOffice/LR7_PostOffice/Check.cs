using System;

namespace LR7_PostOffice;

public class Check : Package, IUrgent
{
    public string BankName { get; set; } = "";
    public bool IsUrgent { get; set; }
    public double AdditionalCost { get; }

    public Check(
        string sender,
        string receiver,
        DateTime sentDate,
        double baseCost,
        string bankName,
        bool isUrgent,
        double additionalCost = 1.00)
        : base(sender, receiver, sentDate, baseCost)
    {
        BankName = bankName?.Trim() ?? "";
        IsUrgent = isUrgent;
        AdditionalCost = additionalCost;

        // пример: чек чуть дороже из-за обработки
        AddCost(0.75);

        if (IsUrgent) AddCost(AdditionalCost);
    }

    public override string ToString()
        => base.ToString() + $", bank='{BankName}'";
}