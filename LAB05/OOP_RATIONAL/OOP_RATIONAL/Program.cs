using OOP_RATIONAL;

Rational r1 = new Rational(4, 8);      // 1/2
Rational r2 = new Rational(2, -5);     // -2/5
Rational r3 = new Rational(-3, -4);    // 3/4

Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine(r3);

// арифметика
Rational a = r1 + r2;
Rational b = r1 - r2;
Rational c = r1 * r3;
Rational d = r3 / r1;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);

// сравнения
Console.WriteLine(r3 > r1);
Console.WriteLine(r2 < r1);
Console.WriteLine(r1 == new Rational(1, 2));
Console.WriteLine(r1 != r2);

// проверка деления на 0
Rational z = new Rational(0, 5);
// следующая строка должна вызвать исключение
// Rational bad = r2 / z;