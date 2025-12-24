using System;

namespace LR7_PostOffice;

public class Letter : Package, IUrgent
{
    public bool International { get; set; }     // международное
    public bool IsUrgent { get; set; }          // срочное
    public double AdditionalCost { get; }       // доплата за срочность

    public Letter(
        string sender,
        string receiver,
        DateTime sentDate,
        double baseCost,
        bool international,
        bool isUrgent,
        double additionalCost = 2.50)
        : base(sender, receiver, sentDate, baseCost)
    {
        International = international;
        IsUrgent = isUrgent;
        AdditionalCost = additionalCost;

        // пример логики цены: международное дороже
        if (International) AddCost(3.00);

        // срочность
        if (IsUrgent) AddCost(AdditionalCost);
    }
}