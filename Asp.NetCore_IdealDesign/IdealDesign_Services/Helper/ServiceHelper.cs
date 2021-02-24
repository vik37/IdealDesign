using IdealDesign_WebModels.EnumsVM;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;

namespace IdealDesign_Services.Helper
{
    public static class ServiceHelper
    {
        // Number of images in folder
        public static int ReturnImageLength(ProductTypeVM type)
        {
            string path = String.Format(@"C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\wwwroot\images\Ideal_galery\{0}\", type);
            string[] directoryPath = Directory.GetFiles(path, "*.jpg");
            return directoryPath.Length;
        }

        // Converts from enum to string and separates the joined words
        public static string GetDescription(System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        // Check image extension is it jpg
        public static bool IsItJpg(IFormFile file)
        {
                string extension = Path.GetExtension(file.FileName).ToLower();                
                switch (extension)
                {
                    case ".jpg":
                        return true;
                    case ".jpeg":
                        return true;
                    default:
                        return false;                        
                }
        }

        // Check image extension is it jpg
        public static bool IsItDocument(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName).ToLower();
            switch (extension)
            {
                case ".docx":
                    return true;
                case ".doc":
                    return true;
                case ".pdf":
                    return true;
                case ".txt":
                    return true;
                default:
                    return false;
            }
        }
    }
}
