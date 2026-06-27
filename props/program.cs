using System;

class Program
{
    static void Main()
    {
        var speed = new Speed(100, "km/h");
        var accel = new Accel(9.8);
        var obj = new MyObject(speed, accel);

        var printer = new Printer();
        obj.Print(printer);
    }
}
