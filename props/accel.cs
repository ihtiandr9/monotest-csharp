public class Accel : MyProperty
{
    public Accel() { Unit = "m/s²"; }

    public Accel(double value, string unit = "m/s²")
        : base(value, unit) {}

    protected override MyProperty Add(double d) => new Accel(Value + d, Unit);
}
