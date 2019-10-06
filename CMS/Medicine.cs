namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            Medications = new HashSet<Medication>();
        }

        [Key]
        public int Med_ID { get; set; }

        public int? Emp_ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? TotalPacks { get; set; }

        public int? PacSize { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expiry { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        public int? Rate { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medication> Medications { get; set; }
    }
}
