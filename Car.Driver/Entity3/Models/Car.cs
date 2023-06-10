namespace Entity3.Models
{
    internal class Car : BaseEntity
    {
        #region mainprops

        public string? Name { get; set; } = null!;

        public int Number { get; set; }

        public int SeatCount { get; set; }

        #endregion        

        public Driver? Driver { get; set; }

        public override string ToString() => $"{Name} {Number} {SeatCount}";
    }
}