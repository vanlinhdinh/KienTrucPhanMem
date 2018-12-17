namespace QuanLyQuanAn.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(50)]
        public string passWordUser { get; set; }

        public bool style { get; set; }
    }
}
