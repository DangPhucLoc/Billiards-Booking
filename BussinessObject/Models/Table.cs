using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Table
    {
        public Table()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        public int TableId { get; set; }
        public int TableTypeId { get; set; }
        public int ClubId { get; set; }
        public bool? IsAvailable { get; set; }

        public virtual Club Club { get; set; } = null!;
        public virtual TableType TableType { get; set; } = null!;
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
