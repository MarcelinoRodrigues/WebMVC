﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Account
    {
        [Display(Name ="Username")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
