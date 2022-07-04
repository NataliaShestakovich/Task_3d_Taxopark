namespace Task_3d_Taxopark
{
    internal class CargoTaxiFactory : ITaxiFactory
    {
        private const int COEFFICIENT_CARGO_VOLUME = 5;
       
        public Car AddCar()
        {
            var cargoCar = new CargoCar();

            var random = new Random();

            cargoCar.Number = Guid.NewGuid();

            cargoCar.Cost = (decimal) random.NextDouble() + random.Next(10000, 199999);

            cargoCar.FuelConsumption = random.Next(10, 40);

            cargoCar.TopSpeed = random.Next(60, 150);

            cargoCar.CarryingCapacity = cargoCar.FuelConsumption > 20 ? random.Next(15, 24) : random.Next(1, 14);
            
            cargoCar.VolumeOfCargoSection = cargoCar.CarryingCapacity * COEFFICIENT_CARGO_VOLUME;

            return cargoCar;
        } 
    }
}
