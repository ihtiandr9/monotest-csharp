using System;

namespace Equations
{
    class Coefficient
    {
        int _val;
        public Coefficient(int val)
        {
            _val = val;
        }
        public override string ToString()
        {
            if (_val == 1) return "";
            return _val.ToString();
        }
        public int Value()
        {
            return _val;
        }
    }
    class Equation
    {
        Coefficient _a;
        Coefficient _b;
        Coefficient _c;
        public Equation(int a, int b, int c)
        {
            _a = new Coefficient(a);
            _b = new Coefficient(b);
            _c = new Coefficient(c);
        }

        public void PrintMe()
        {
            string eqString = "";
            if (_a.Value() != 0) eqString = _a.ToString() + "x^2";
            if (_b.Value() != 0) eqString += " + " + _b.ToString() + "x";
            if (_c.Value() != 0) eqString += " + " + _c.ToString();
            eqString += " = 0";
            Console.WriteLine("Solving Equation\n");
            Console.WriteLine(eqString);            
        }
    }
}