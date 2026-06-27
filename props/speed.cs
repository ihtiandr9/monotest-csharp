public class Speed : MyProperty
{
    public Speed() { Unit = "m/s"; }

    public Speed(double value, string unit = "m/s")
        : base(value, unit) {}
}
