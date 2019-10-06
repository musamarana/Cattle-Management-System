namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DryPeriod")]
    public partial class DryPeriod
    {
        [Key]
        public int Dry_ID { get; set; }

        public int Animal_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public virtual Animal Animal { get; set; }
    }
}
