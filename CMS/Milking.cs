namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Milking")]
    public partial class Milking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Milking()
        {
            MilkBuyers = new HashSet<MilkBuyer>();
        }

        [Key]
        public int Milking_ID { get; set; }

        public int? Animal_ID { get; set; }

        public int? Emp_ID { get; set; }

        public int? Amount_Ltr { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public TimeSpan? Time { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MilkBuyer> MilkBuyers { get; set; }
    }
}
