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

    public override string ToString() => $"{Value} {Unit}";

    public void Print(Printer p) => p.PrintLine($"{Value} {Unit}");
}
