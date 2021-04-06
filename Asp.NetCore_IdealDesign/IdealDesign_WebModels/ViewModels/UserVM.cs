using IdealDesign_Validation;
using IdealDesign_WebModels.EnumsVM;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace IdealDesign_WebModels.VewModels
{
    public class UserVM
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please select file")]
        [MaxFileSize(5 * 1024 * 1024)]
        //[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.jpeg|.jpg|.JPEG|.JPG)$", ErrorMessage = "Only Image files allowed.")]
        public List<IFormFile> Photos { get; set; }
        public ProductTypeVM ProductType { get; set; }
    }
}
