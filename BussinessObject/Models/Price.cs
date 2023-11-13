using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Price
    {
        public int TableTypeId { get; set; }
        public int SlotId { get; set; }
        public int? Price1 { get; set; }

        public virtual Slot Slot { get; set; } = null!;
        public virtual TableType TableType { get; set; } = null!;
    }
}
