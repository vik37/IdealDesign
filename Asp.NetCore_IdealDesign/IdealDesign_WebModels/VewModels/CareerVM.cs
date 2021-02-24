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
        [Required(ErrorMessage ="First name is required"), MinLength(3,ErrorMessage ="Can not be minimum 3 charachters"),
            MaxLength(20,ErrorMessage ="Can not be maximum of 20 charachters")]
        public string Firstname { get; set; }
        [Display(Name = "LAST NAME")]
        [Required(ErrorMessage = "Last name is required"), MinLength(3, ErrorMessage = "Can not be minimum 3 charachters"),
            MaxLength(20, ErrorMessage = "Can not be maximum of 20 charachters")]
        public string Lastname { get; set; }
        [Display(Name = "PHONE")]
        [Required(ErrorMessage = "Phone is required"), MinLength(6, ErrorMessage = "Can not be minimum 3 charachters"),
            MaxLength(20, ErrorMessage = "Can not be maximum of 10 charachters")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Description is required"), MinLength(20, ErrorMessage = "Can not be minimum 20 charachters"),
            MaxLength(2501, ErrorMessage = "Can not be maximum of 10 charachters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select file")]
        /*[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(docx|DOCX|pdf|PDF)$", ErrorMessage = "Only Microsoft word and pdf files allowed.")]*/
        public IFormFile Resume { get; set; }

    }
}
