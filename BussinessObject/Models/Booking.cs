using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Booking
    {
        public Booking()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public int ClubId { get; set; }
        public int? ClubStaffId { get; set; }
        public bool? BookingStatus { get; set; }
        public DateTime? BookDate { get; set; }

        public virtual Club Club { get; set; } = null!;
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
