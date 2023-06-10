using System.Collections.Generic;

namespace Entity3.Models
{
    internal class Driver : BaseEntity
    {
        #region mainprops

        public string? FirstName { get; set; } = null!;

        public string? LastName { get; set; } = null!;

        public int Phone { get; set; }

        public string? Username { get; set; } = null!;

        public string? Password { get; set; } = null!;

        public string? HomeAdress { get; set; } = null!;

        public string? License { get; set; } = null!;
        #endregion

        public int? CarId { get; set; }

        public Car? Car { get; set; }

        public ICollection<Ride>? Rides { get; set; }
    }
}