namespace QuanLyQuanAn.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableFood")]
    public partial class TableFood
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableFood()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        public int idTable { get; set; }

        [Required]
        [StringLength(50)]
        public string nameTable { get; set; }

        [Required]
        [StringLength(50)]
        public string statusTable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
