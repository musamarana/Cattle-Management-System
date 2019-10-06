namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Breeding")]
    public partial class Breeding
    {
        [Key]
        [Column("Breeding")]
        public int Breeding1 { get; set; }

        public int? Animal_ID { get; set; }

        public int? Animal_ID_M { get; set; }

        public int? Emp_ID { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Dose { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Animal Animal1 { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
