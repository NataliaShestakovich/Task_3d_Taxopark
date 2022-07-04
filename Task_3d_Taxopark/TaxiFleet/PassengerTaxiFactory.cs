namespace Task_3d_Taxopark
{
    public class PassengerTaxiFactory : ITaxiFactory
    {
        public Car AddCar()
        {
            var passangerCar = new PassengerCar();

            Random random = new Random();

            passangerCar.Number = Guid.NewGuid();

            passangerCar.Cost = (decimal) random.NextDouble() + random.Next(5000, 199999);

            passangerCar.FuelConsumption = random.Next(5, 40);

            passangerCar.TopSpeed = random.Next(100, 250);

            passangerCar.NumberOfSeats = passangerCar.FuelConsumption > 20 ? random.Next(8, 50) : random.Next(1, 7);
            
            passangerCar.AirConditioner = random.Next(0, 1) == 1;

            passangerCar.BabyCarSeat = random.Next(0, 1) == 1;

            return passangerCar;
        }    
    }
}