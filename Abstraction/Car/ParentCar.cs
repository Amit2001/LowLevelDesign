using System;
namespace Car
{
public class ParentCar
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public ParentCar(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine("The engine is starting.");
    }
    public virtual void StopEngine()
    {
        Console.WriteLine("The engine is stopping.");
    }
    public virtual void Drive()
    {
        Console.WriteLine("The car is driving.");
    }
    public virtual void Break()
    {
        Console.WriteLine("The car is breaking.");
    }
}
}
