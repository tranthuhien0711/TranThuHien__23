namespace TranThuHien__23.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongBan")]
    public partial class PhongBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhongBan { get; set; }

        [Required]
        [StringLength(50)]
        public string TenPhongBan { get; set; }
    }
}
