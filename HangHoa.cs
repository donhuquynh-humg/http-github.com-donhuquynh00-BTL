using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public string MaChatLieu { get; set; }
        public string SoLuong { get; set; }
        public string DonGiaNhap { get; set; }
        public string DonGiaBan { get; set; }
    }
}