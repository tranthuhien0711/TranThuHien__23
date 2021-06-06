namespace TranThuHien__23.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(20)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public int MaPhongBan { get; set; }
    }
}
