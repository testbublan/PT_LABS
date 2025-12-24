using System;

namespace LR7_PostOffice;

public abstract class Package
{
    private string sender = "";
    private string receiver = "";

    public string Sender
    {
        get => sender;
        set => sender = value?.Trim() ?? "";
    }

    public string Receiver
    {
        get => receiver;
        set => receiver = value?.Trim() ?? "";
    }

    public DateTime SentDate { get; set; }   // дата отправления
    public double Cost { get; protected set; } // стоимость пересылки

    protected Package(string sender, string receiver, DateTime sentDate, double baseCost)
    {
        Sender = sender;
        Receiver = receiver;
        SentDate = sentDate;

        if (baseCost < 0) throw new ArgumentException("Cost cannot be negative");
        Cost = baseCost;
    }

    // для пересчёта стоимости (например, вес/международное/срочность)
    protected void AddCost(double add)
    {
        if (add < 0) throw new ArgumentException("Additional cost cannot be negative");
        Cost += add;
    }

    public override string ToString()
        => $"{GetType().Name}: from='{Sender}', to='{Receiver}', date={SentDate:yyyy-MM-dd}, cost={Cost:F2}";
}