using LR7_PostOffice;
using System.Diagnostics.Metrics;

PostOffice office = new PostOffice();

var p1 = new Letter("Ivan", "Olga", new DateTime(2025, 12, 10), baseCost: 2.0, international: false, isUrgent: true);
var p2 = new Letter("John", "Maria", new DateTime(2025, 12, 1), baseCost: 2.0, international: true, isUrgent: false);
var p3 = new Box("Shop", "Alex", new DateTime(2025, 11, 30), baseCost: 4.0, weightKg: 3.2, isUrgent: true);
var p4 = new Box("Kate", "Denis", new DateTime(2025, 12, 12), baseCost: 4.0, weightKg: 0.7, isUrgent: false);
var p5 = new Check("Bank", "Client", new DateTime(2025, 12, 5), baseCost: 1.5, bankName: "ABC Bank", isUrgent: true);
var p6 = new Check("Company", "Partner", new DateTime(2025, 12, 15), baseCost: 1.5, bankName: "Finance LTD", isUrgent: false);
var p7 = new Letter("Riga", "Berlin", new DateTime(2025, 11, 25), baseCost: 2.0, international: true, isUrgent: true);

office.ReceivePackage(p1);
office.ReceivePackage(p2);
office.ReceivePackage(p3);
office.ReceivePackage(p4);
office.ReceivePackage(p5);
office.ReceivePackage(p6);
office.ReceivePackage(p7);

Console.WriteLine(office);
Console.WriteLine($"\nAverage cost: {office.CalculateAvgPackageCost():F2}");

Console.WriteLine("\nSend oldest package:");
office.SendPackage();

Console.WriteLine("\nAfter sending:");
Console.WriteLine(office);