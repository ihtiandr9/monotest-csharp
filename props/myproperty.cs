public class MyProperty
{
    public double Value { get; set; }
    public string Unit { get; set; } = "";

    public MyProperty() {}

    public MyProperty(double value, string unit)
    {
        Value = value;
        Unit = unit;
    }

    public static implicit operator double(MyProperty p) => p.Value;

    public static MyProperty operator +(MyProperty p, double d) => p.Add(d);
    protected virtual MyProperty Add(double d) => new MyProperty(Value + d, Unit);

    public override string ToString() => $"{Value} {Unit}";

    public void Print(Printer p) => p.PrintLine($"{Value} {Unit}");
}
