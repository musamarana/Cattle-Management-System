namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Abortion")]
    public partial class Abortion
    {
        [Key]
        public int Abortion_ID { get; set; }

        public int? Animal_ID { get; set; }

        public int? Emp_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
