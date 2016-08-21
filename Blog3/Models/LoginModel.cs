using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog3.Models
{
    public class LoginModel
    {
        [Display(Name="Felhasználónév")]
        public string UserName { get; set; }

        [Display(Name ="Jelszó")]
        public string Passwd { get; set; }
    }
}