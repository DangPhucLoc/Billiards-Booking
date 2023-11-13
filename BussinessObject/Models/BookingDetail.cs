using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class BookingDetail
    {
        public int BookingDetailId { get; set; }
        public int BookingId { get; set; }
        public int SlotId { get; set; }
        public int TableId { get; set; }
        public int? Price { get; set; }

        public virtual Booking Booking { get; set; } = null!;
        public virtual Slot Slot { get; set; } = null!;
        public virtual Table Table { get; set; } = null!;
    }
}
