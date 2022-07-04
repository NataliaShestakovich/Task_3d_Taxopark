namespace Task_3d_Taxopark
{
    public class PassengerCar : Car
    {
        public override string? CarType { get => "passenger"; }

        public bool AirConditioner { get; set; }

        public bool BabyCarSeat { get; set; }

        public int NumberOfSeats { get; set; }

        public override string ToString()
        {
            var message = $"{base.ToString()}\nNumber of seats: {NumberOfSeats}\nAir conditioner: {AirConditioner}\nBaby carSeat: {BabyCarSeat}\n{new string('*', 50)}";

            return message;
        }
    }
}
