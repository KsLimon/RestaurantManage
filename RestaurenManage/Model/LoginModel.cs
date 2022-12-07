﻿using System.ComponentModel.DataAnnotations;

namespace RestaurenManage.Model
{
    public class LoginModel
    {
        [Key]
        [Required(ErrorMessage = "Enter your Login ID")]
        public string LoginID { get; set; }

        [Required(ErrorMessage = "Enter your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool? RememberMe { get; set; }
    }
}
