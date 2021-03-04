using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IdealDesign_WebModels.VewModels
{
    public class CareerVM
    {
        public int Id { get; set; }
        [Display(Name ="FIRST NAME")]
        [Required(ErrorMessage ="First name is required"), MinLength(3,ErrorMessage = "Less than 3 letters is not allowed"),
            MaxLength(20,ErrorMessage = "More than 20 letters are not allowed")]
        public string Firstname { get; set; }
        [Display(Name = "LAST NAME")]
        [Required(ErrorMessage = "Last name is required"), MinLength(3, ErrorMessage = "Less than 3 letters is not allowed"),
            MaxLength(20, ErrorMessage = "More than 20 letters are not allowed")]
        public string Lastname { get; set; }
        [Display(Name = "PHONE")]
        [Required(ErrorMessage = "Phone is required"), MinLength(6, ErrorMessage = "Less than 6 numbers is not allowed"),
            MaxLength(20, ErrorMessage = "More than 10 letters are not allowed")]
        public string Phone { get; set; }
        [Display(Name ="DESCRIPTION")]
        [Required(ErrorMessage = "Description is required"), MinLength(20, ErrorMessage = "Less than 20 letters is not allowed"),
            MaxLength(2501, ErrorMessage = "More than 2501 letters are not allowed")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select file")]
        /*[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(docx|DOCX|pdf|PDF)$", ErrorMessage = "Only Microsoft word and pdf files allowed.")]*/
        public IFormFile Resume { get; set; }

    }
}
