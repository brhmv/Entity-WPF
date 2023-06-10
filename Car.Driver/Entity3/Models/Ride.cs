namespace Entity3.Models
{
    internal class Ride : BaseEntity
    {
        public string RideName { get; set; } = null!;


        public int DriverId { get; set; }

        public Driver Driver { get; set; } = null!;


        public int CarId { get; set; }

        public Car Car { get; set; } = null!;   
    }
}