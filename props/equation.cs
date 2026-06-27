using System;
using System.Numerics;

namespace Equations
{
    class Coefficient
    {
        public int Value { get; set; }

        public Coefficient(int val)
        {
            Value = val;
        }

        public override string ToString()
        {
            if (Value == 1) return "";
            return Value.ToString();
        }
    }
    class Equation
    {
        Coefficient a;
        Coefficient b;
        Coefficient c;
        public Equation(int a, int b, int c)
        {
            this.a = new Coefficient(a);
            this.b = new Coefficient(b);
            this.c = new Coefficient(c);
        }

        public void PrintMe()
        {
            string eqString = "";
            if (a.Value != 0) eqString = a.ToString() + "x^2";
            if (b.Value != 0) eqString += " + " + b.ToString() + "x";
            if (c.Value != 0) eqString += " + " + c.ToString();
            eqString += " = 0";
            Console.WriteLine("Solving Equation\n");
            Console.WriteLine(eqString);
        }

        public double Discriminant()
        {
            return b.Value * b.Value - 4 * a.Value * c.Value;
        }

        public Complex[] Roots()
        {
            double d = Discriminant();
            double re = -b.Value / (2.0 * a.Value);
            if (d >= 0)
                return new Complex[] {
                    new Complex(re + Math.Sqrt(d) / (2.0 * a.Value), 0),
                    new Complex(re - Math.Sqrt(d) / (2.0 * a.Value), 0)
                };
            else
                return new Complex[] {
                    new Complex(re, Math.Sqrt(-d) / (2.0 * a.Value)),
                    new Complex(re, -Math.Sqrt(-d) / (2.0 * a.Value))
                };
        }
    }
}
