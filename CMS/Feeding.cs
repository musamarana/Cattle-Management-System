namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feeding")]
    public partial class Feeding
    {
        public int? Animal_ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Feed_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public TimeSpan? Time { get; set; }

        public int? Quantity { get; set; }

        [StringLength(50)]
        public string Method { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual FeedStock FeedStock { get; set; }
    }
}
