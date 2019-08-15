﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MadPay.Data.Dtos.Site.Admin
{
    public class UseForLoginDto
    {
        [Required]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمیباشد")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsRemember { get; set; }
    }
}
