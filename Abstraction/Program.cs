using System;
using Car;

class Program
{
	static void Main(string[] args)
	{
		ParentCar sportsCar = new SportsCar("Ferrari", "488 GTB", 2020);
		sportsCar.StartEngine();
	}
}
