namespace Task_3d_Taxopark
{
    public abstract class Car : IComparable<Car>
    {
        public abstract string? CarType { get; }

        public decimal Cost { get; set; }

        public double FuelConsumption { get; set; }

        public int TopSpeed { get; set; }

        public Guid Number;

        public override string ToString()
        {
            string message = $"\nCarType: {CarType}\nNumber: {Number}\nCost of car: {Cost:F}\nFuel Consumption: {FuelConsumption}\nTopSpeed: {TopSpeed}";

            return message;
        }

        public int CompareTo(Car? car)
        {
            if (car is null) throw new ArgumentException("The incorrect value of the parameter");

            return FuelConsumption.CompareTo(car.FuelConsumption);
        }
    }
}
