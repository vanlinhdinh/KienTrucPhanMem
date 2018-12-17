namespace QuanLyQuanAn.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillInfoes = new HashSet<BillInfo>();
        }

        [Key]
        public int idBill { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateCheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateCheckOUt { get; set; }

        public int? discount { get; set; }

        public int? idTable { get; set; }

        public int? totalPrice { get; set; }

        public bool? statusBill { get; set; }

        public virtual TableFood TableFood { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfoes { get; set; }
    }
}
