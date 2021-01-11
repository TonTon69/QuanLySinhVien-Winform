namespace QuanLySinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQua")]
    public partial class KetQua
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMH { get; set; }

        public double Diem { get; set; }

        public virtual Mon Mon { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
