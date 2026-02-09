namespace Car
{
    public class SportsCar : ParentCar
    {
        public SportsCar(string make, string model, int year) : base(make, model, year) { }

        public override void StartEngine()
        {
            Console.WriteLine("Sports Car Make: "+Make+", Model: "+Model+", Year: "+Year);
            Console.WriteLine("The sports car engine roars to life!");
        }

        public override void StopEngine()
        {
            Console.WriteLine("The sports car engine shuts down.");
        }

        public override void Drive()
        {
            Console.WriteLine("The sports car speeds down the road!");
        }

        public override void Break()
        {
            Console.WriteLine("The sports car comes to a swift stop.");
        }
    }
}