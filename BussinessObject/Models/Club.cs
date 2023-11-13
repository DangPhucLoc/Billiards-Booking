using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Club
    {
        public Club()
        {
            Bookings = new HashSet<Booking>();
            Tables = new HashSet<Table>();
        }

        public int ClubId { get; set; }
        public string ClubName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? FanpageLink { get; set; }
        public string? AvatarLink { get; set; }
        public int? OpenTime { get; set; }
        public int? CloseTime { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }
}
