namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Calving")]
    public partial class Calving
    {
        [Key]
        public int Calving_ID { get; set; }

        public int Animal_ID { get; set; }

        public int? Emp_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? Weight { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
