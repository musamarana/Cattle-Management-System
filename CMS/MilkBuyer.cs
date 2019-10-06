namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MilkBuyer")]
    public partial class MilkBuyer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Buyer_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Milking_ID { get; set; }

        public DateTime? DateTime { get; set; }

        public int? Quantity { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual Milking Milking { get; set; }
    }
}
