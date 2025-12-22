namespace OOP_RATIONAL
{
    public class Rational
    {
        // приватные поля
        private int numerator;
        private int denominator;

        // свойство числителя с вызовом Simplify()
        public int Numerator
        {
            get { return numerator; }
            set
            {
                numerator = value;
                Simplify();
            }
        }

        // свойство знаменателя с валидацией и Simplify()
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("Denominator should not be = 0");
                denominator = value;
                Simplify();
            }
        }

        // конструктор с двумя параметрами + валидация
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
                throw new DivideByZeroException("Denominator should not be = 0");
            this.denominator = denominator;
            Simplify();
        }

        // конструктор с одним параметром
        public Rational(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
            Simplify();
        }

        // ToString для красивого вывода
        public override string ToString()
        {
            return $"Rational: {Numerator}/{Denominator}";
        }

        // НОД (алгоритм Евклида)
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // упрощение дроби + знак в знаменателе
        private void Simplify()
        {
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            if (gcd == 0) return; // защита для 0/что‑то

            numerator /= gcd;
            denominator /= gcd;
        }

        // перегрузка оператора +
        public static Rational operator +(Rational r1, Rational r2)
        {
            int newDen = r1.Denominator * r2.Denominator;
            int newNum = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
            return new Rational(newNum, newDen);
        }

        // перегрузка оператора -
        public static Rational operator -(Rational r1, Rational r2)
        {
            int newDen = r1.Denominator * r2.Denominator;
            int newNum = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
            return new Rational(newNum, newDen);
        }

        // перегрузка оператора *
        public static Rational operator *(Rational r1, Rational r2)
        {
            int newDen = r1.Denominator * r2.Denominator;
            int newNum = r1.Numerator * r2.Numerator;
            return new Rational(newNum, newDen);
        }

        // перегрузка оператора /
        public static Rational operator /(Rational r1, Rational r2)
        {
            if (r2.Numerator == 0)
                throw new DivideByZeroException("Cannot divide by zero rational");

            int newDen = r1.Denominator * r2.Numerator;
            int newNum = r1.Numerator * r2.Denominator;
            return new Rational(newNum, newDen);
        }

        // операторы сравнения > < >= <= == !=
        public static bool operator >(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator;
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }

        public static bool operator >=(Rational r1, Rational r2)
        {
            return !(r1 < r2);
        }

        public static bool operator <=(Rational r1, Rational r2)
        {
            return !(r1 > r2);
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            if (ReferenceEquals(r1, r2)) return true;
            if (ReferenceEquals(r1, null) || ReferenceEquals(r2, null)) return false;
            return r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Rational other) return false;
            return this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }
    }
}
