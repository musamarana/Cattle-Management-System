namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeedStock")]
    public partial class FeedStock
    {
        [Key]
        public int Feed_ID { get; set; }

        public int Emp_ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? TotalBags { get; set; }

        public int? BagSize { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expiry { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        public int? Rate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Feeding Feeding { get; set; }
    }
}
