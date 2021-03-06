﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class RegisterViewModel
    {
        [Key]
        public long ID { get; set; }

        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Yêu cầu nhập vào tên đăng nhập!")]
        public string UserName { set; get; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhất phải 6 kí tự!")]
        [Required(ErrorMessage = "Yêu cầu nhập vào mật khẩu!")]
        public string Password { set; get; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không trùng khớp!")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Yêu cầu nhập vào họ và tên!")]
        public string Name { set; get; }

        [Display(Name = "Địa chỉ")]
        public string Address { set; get; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Yêu cầu nhập vào địa chỉ email!")]
        public string Email { set; get; }

        [Display(Name = "Số điện thoại")]
        public string Phone { set; get; }

    }
}