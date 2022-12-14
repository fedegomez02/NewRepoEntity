namespace WindowsFormspPub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Discount
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string discounttype { get; set; }

        [StringLength(4)]
        public string stor_id { get; set; }

        public short? lowqty { get; set; }

        public short? highqty { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal discount { get; set; }

        public virtual Store stores { get; set; }
    }
}
