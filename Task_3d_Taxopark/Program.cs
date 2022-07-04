namespace Task_3d_Taxopark
{
    internal class Program
    {
        static readonly CargoTaxiFactory cargoTaxiFactory = new();
        static readonly PassengerTaxiFactory passengerTaxiFactory = new();
        static readonly CarPark carPark = new();

        public static void Main(string[] args)
        {
            FirstMenu();
            SecondMenu();
        }

        private static void FirstMenu()
        {
            bool choice = false;

            while (!choice)
            {
                Console.WriteLine("\n<<< Car park >>>");
                Console.WriteLine(" Choose a way to add transport: ");
                Console.WriteLine("> A - Automatically");
                Console.WriteLine("> M - Manually");

                var inputParam = Console.ReadLine();
                Console.Clear();

                switch (inputParam?.ToLower())
                {
                    case "a":
                        FillTaxiParkAutomatically();
                        choice = true;
                        break;

                    case "m":
                        var countOfCargoCars = GetCountCar("cargo");
                        var countOfPassengerCars = GetCountCar("passeger");
                        FillTaxiParkManually(countOfCargoCars, countOfPassengerCars);
                        choice = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid value entered");
                        Console.ResetColor();
                        break;
                }
            }
        }

        private static void SecondMenu()
        {
            bool choice = false;

            while (!choice)
            {
                Console.WriteLine("\n<<< Car park >>>");
                Console.WriteLine(" Choose a next action: ");
                Console.WriteLine("> C - Get car park cost");
                Console.WriteLine("> P - Print car list");
                Console.WriteLine("> F - Get sorted by fuel consumption list cars");
                Console.WriteLine("> T - Get sorted by type cars list cars");
                Console.WriteLine("> W - Selected cars by speed");
                Console.WriteLine("> E - Exit");

                var inputParam = Console.ReadLine();
                Console.Clear();

                switch (inputParam?.ToLower())
                {
                    case "c":
                        carPark.GetCostOfCarPark();
                        break;

                    case "p":
                        carPark.PrintCarPark();
                        break;

                    case "f":
                        carPark.SortCarsByFuelConsumption();
                        carPark.PrintCarPark();
                        break;

                    case "t":
                        carPark.SortCarsByType();
                        carPark.PrintCarPark();
                        break;

                    case "w":
                        var random = new Random();
                        var minValue = random.Next(0, 100);
                        var maxValue = random.Next(100, 200);
                        carPark.PrintSelectedCarsBySpeed(minValue, maxValue);
                        break;

                    case "e":
                        choice = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid value entered");
                        Console.ResetColor();
                        break;
                }
            }
        }

        private static uint GetCountCar(string typeCar)
        {
            uint count = 0;

            bool isNumber = false;

            while (!isNumber)
            {
                Console.WriteLine($"Enter the number of {typeCar} cars");

                string? input = Console.ReadLine();
                Console.Clear();

                isNumber = uint.TryParse(input, out count);

                if (!isNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid value entered");
                    Console.ResetColor();
                }
            }
            return count;
        }

        private static void FillTaxiParkAutomatically()
        {
            var random = new Random();

            var countOfCargoCars = random.Next(1, 5);

            var countOfPassengerCars = random.Next(1, 5);

            for (int i = 1; i <= countOfCargoCars; i++)
            {
                carPark.AddTaxiCar(cargoTaxiFactory);
            }

            for (int i = 1; i <= countOfPassengerCars; i++)
            {
                carPark.AddTaxiCar(passengerTaxiFactory);
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Added {countOfCargoCars + countOfPassengerCars} cars\ncargo car(s): {countOfCargoCars}\npassenger car(s): {countOfPassengerCars}");
            Console.ResetColor();
        }

        private static void FillTaxiParkManually(uint countOfCargoCars, uint countOfPassengerCars)
        {
            for (int i = 1; i <= countOfCargoCars; i++)
            {
                carPark.AddTaxiCar(cargoTaxiFactory);
            }

            for (int i = 1; i <= countOfPassengerCars; i++)
            {
                carPark.AddTaxiCar(passengerTaxiFactory);
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Added {countOfCargoCars + countOfPassengerCars} cars\ncargo car(s): {countOfCargoCars}\npassenger car(s): {countOfPassengerCars}");
            Console.ResetColor();
        }
    }
}