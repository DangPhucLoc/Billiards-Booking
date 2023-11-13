using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class TableType
    {
        public TableType()
        {
            Prices = new HashSet<Price>();
            Tables = new HashSet<Table>();
        }

        public int TableTypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public string? TypeDescription { get; set; }

        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }
}
