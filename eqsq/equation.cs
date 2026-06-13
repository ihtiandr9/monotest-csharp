using System;

namespace Equations
{
    class Coefficient
    {
        int val;
        public Coefficient(int val)
        {
            this.val = val;
        }
        public override string ToString()
        {
            if (val == 1) return "";
            return val.ToString();
        }
        public override ToIint()
        {
            return val;
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
            if (a != 0) eqString = a.ToString() + "x^2";
            if (b != 0) eqString += " + " + b.ToString() + "x";
            if (c != 0) eqString += " + " + c.ToString();
            eqString += " = 0";
            Console.WriteLine("Solving Equation\n");
            Console.WriteLine(eqString);            
        }
    }
}
