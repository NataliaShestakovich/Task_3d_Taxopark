namespace Task_3d_Taxopark
{
    public class CargoCar : Car
    {
        public override string? CarType { get => "cargo"; }

        public int CarryingCapacity { get; set; }

        public int VolumeOfCargoSection { get; set; }

        public override string ToString()
        {
            var message = $"{base.ToString()}\nCarrying capacity: {CarryingCapacity}\nVolume of argoSection: {VolumeOfCargoSection}\n{new string('*', 50)}";

            return message;
        }
    }
}
