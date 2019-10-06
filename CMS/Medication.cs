namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medication")]
    public partial class Medication
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Animal_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Med_ID { get; set; }

        [StringLength(50)]
        public string Disease { get; set; }

        public DateTime? time { get; set; }

        public int? Quantity { get; set; }

        [StringLength(50)]
        public string Method { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Medicine Medicine { get; set; }
    }
}
