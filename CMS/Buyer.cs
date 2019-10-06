namespace CMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buyer")]
    public partial class Buyer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buyer()
        {
            MilkBuyers = new HashSet<MilkBuyer>();
        }

        [Key]
        public int Buyer_ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? CNIC { get; set; }

        public long? Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MilkBuyer> MilkBuyers { get; set; }
    }
}
