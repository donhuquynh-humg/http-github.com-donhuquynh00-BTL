using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        public string NgayBan { get; set; }
        public string MaKhach { get; set; }
        public string TongTien { get; set; }
    }
}