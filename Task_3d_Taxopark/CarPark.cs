namespace Task_3d_Taxopark
{
    public class CarPark
    {
        public CarPark()
        {
            Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }

        public void AddTaxiCar(ITaxiFactory taxiFactory)
        {
            Car newCar = taxiFactory.AddCar();

            Cars.Add(newCar);
        }

        public void SortCarsByFuelConsumption()
        {
            Cars = Cars.OrderBy(obj => obj.FuelConsumption).ToList();
        }

        public void SortCarsByCost()
        {
            Cars = Cars.OrderBy(obj => obj.Cost).ToList();
        }

        public void SortCarsByType()
        {
            Cars = Cars.OrderBy(obj => obj.CarType).ToList();
        }

        public void PrintCarPark()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Number of cars in taxi park:{Cars.Count}");
            Console.ResetColor();

            foreach (var car in Cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public void GetCostOfCarPark()
        {
            decimal costAllCars = 0;

            foreach (var car in Cars)
            {
                costAllCars += car.Cost;
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"The cost of all car taxi {costAllCars:F}");
            Console.ResetColor();
        }

        public void PrintSelectedCarsBySpeed(int minValue, int maxValue)
        {
            List<Car> selectedCars = new();

            foreach (var car in Cars)
            {
                if (car.TopSpeed >= minValue || car.TopSpeed <= maxValue)
                {
                    selectedCars.Add(car);

                    Console.WriteLine(car.ToString());
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"In the range {minValue} k/h - {maxValue} k/h {selectedCars?.Count} cars were found.");
            Console.ResetColor();
        }
    }
}
