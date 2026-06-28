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
        
        printer.PrintLine("\nAfter 2s acceleration:");
        obj.Speed = (Speed)(obj.Speed + 2 * obj.Accel);
        obj.Print(printer);

        printer.PrintLine("\nAfter 3s deceleration:");
        obj.Speed = (Speed)(obj.Speed - 3 * obj.Accel);
        obj.Print(printer);
    }
}
