using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    [Table("ChatLieus")]
    public class ChatLieu
    {
        [Key]
        public int ID { get; set; }
        public string MaChatLieu { get; set; }
        public string TenChatLieu { get; set; }
    }
}