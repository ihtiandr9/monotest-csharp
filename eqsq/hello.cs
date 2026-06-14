using System;
using System.Numerics;
using Equations;

namespace Hello
{
  class Hello
  {
    static void Main(string[] args)
    {
      int argc = args.Length;
      Equation eq;

      switch (argc)
      {
        case 3:
          eq = new Equation(int.Parse(args[0]), int.Parse(args[1]), int.Parse(args[2]));
          break;
        case 2:
          eq = new Equation(int.Parse(args[0]), int.Parse(args[1]), 0);
          break;
        case 1:
          eq = new Equation(int.Parse(args[0]), 0, 0);
          break;
        default:
          eq = new Equation(0, 0, 0);
          break;
      }
      eq.PrintMe();
      Console.WriteLine("Discriminant = " + eq.Discriminant().ToString("F4"));

      Complex[] roots = eq.Roots();
      for (int i = 0; i < roots.Length; i++)
          Console.WriteLine("Root" + (i + 1) + " = (" +
              roots[i].Real.ToString("F4") + ", " +
              roots[i].Imaginary.ToString("F4") + ")");
    }
  }
}