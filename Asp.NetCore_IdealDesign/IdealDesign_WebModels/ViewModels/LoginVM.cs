using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IdealDesign_WebModels.VewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Please enter username")]
        [Display(Name ="Username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Please enter password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
