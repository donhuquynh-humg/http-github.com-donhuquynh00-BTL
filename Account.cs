using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage= "Username is Required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required.")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
      
      
    }
}