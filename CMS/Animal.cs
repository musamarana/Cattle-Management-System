namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Animal")]
    public partial class Animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Animal()
        {
            Abortions = new HashSet<Abortion>();
            Breedings = new HashSet<Breeding>();
            Breedings1 = new HashSet<Breeding>();
            Calvings = new HashSet<Calving>();
            DryPeriods = new HashSet<DryPeriod>();
            Feedings = new HashSet<Feeding>();
            Medications = new HashSet<Medication>();
            Milkings = new HashSet<Milking>();
        }

        [Key]
        public int Animal_ID { get; set; }

        public int? EarTag { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string OriginCountry { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Breed { get; set; }

        [StringLength(50)]
        public string Lactation { get; set; }

        public int? Sire { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InsertionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthdate { get; set; }

        public int? Age { get; set; }

        public int? Weight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abortion> Abortions { get; set; }

        public virtual AniEmployee AniEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Breeding> Breedings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Breeding> Breedings1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calving> Calvings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DryPeriod> DryPeriods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feeding> Feedings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medication> Medications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Milking> Milkings { get; set; }
    }
}
