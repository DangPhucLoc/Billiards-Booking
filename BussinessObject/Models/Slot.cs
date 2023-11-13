using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Slot
    {
        public Slot()
        {
            BookingDetails = new HashSet<BookingDetail>();
            Prices = new HashSet<Price>();
        }

        public int SlotId { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}
