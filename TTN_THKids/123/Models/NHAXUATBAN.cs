namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAXUATBAN")]
    public partial class NHAXUATBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAXUATBAN()
        {
            DAUSACHes = new HashSet<DAUSACH>();
        }

        [Key]
        [StringLength(15)]
        public string MaNhaXuatBan { get; set; }

        [StringLength(50)]
        public string TenNhaXuatBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAUSACH> DAUSACHes { get; set; }
    }
}
