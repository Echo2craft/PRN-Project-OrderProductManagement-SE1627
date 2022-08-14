using System;
using System.Collections.Generic;

#nullable disable

namespace ProductRepo1.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public DateTime? PayTime { get; set; }
        public double Amount { get; set; }
        public int OrderId { get; set; }
        public int PayType { get; set; }

        public virtual Order Order { get; set; }
    }
}
