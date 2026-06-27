public class MyObject
{
    public Speed Speed { get; set; }
    public Accel Accel { get; set; }

    public MyObject() {}

    public MyObject(Speed speed, Accel accel)
    {
        Speed = speed;
        Accel = accel;
    }

    public override string ToString() =>
        $"MyObject [Speed: {Speed}, Accel: {Accel}]";

    public void Print(Printer p)
    {
        p.PrintLine("Hello from Mono!");
        p.PrintLine($"MyObject [Speed: {Speed}, Accel: {Accel}]");
        p.Print("Speed: "); Speed.Print(p);
        p.Print("Accel: "); Accel.Print(p);
    }
}
