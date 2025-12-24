namespace LR7_PostOffice;

public interface IUrgent
{
    double AdditionalCost { get; }   // доплата за срочность
    bool IsUrgent { get; }           // признак срочности
}