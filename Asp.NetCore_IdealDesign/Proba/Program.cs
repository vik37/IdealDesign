using System;
using System.Reflection;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = GetDescription(ProductType.BathroomFurniture);

            //Console.WriteLine(name);
            //string[] splitted = name.Split(" ");
            //Console.WriteLine("---------------------");
            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    Console.WriteLine($"{splitted[0]}{splitted[1]}");
            //}
            //Console.WriteLine();


            //int someLength = ReturnLength(ProductType.Kitchens);

            //Console.WriteLine(someLength);
            Regex rg = new Regex("^[0-9]$");
            string txt = "ghgjg";
            if (rg.IsMatch(txt))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            
            Console.ReadLine();
        }

        public static string GetDescription(System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        public static int ReturnLength(ProductType type)
        {
            string path = String.Format(@"C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\wwwroot\images\Ideal_galery\{0}\", type);
            //string realPath = @"C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\wwwroot\images\Ideal_galery\BathroomFurniture";
            string[] directoryPath = Directory.GetFiles(path, "*.jpg");
            return directoryPath.Length;
        }
    }
}
