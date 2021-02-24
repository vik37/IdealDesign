using IdealDesign_Domain.Enums;
using IdealDesign_WebModels.EnumsVM;
using IdealDesign_WebModels.VewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductVM> GetAllProducts();
        ProductVM GetProductById(int id);
        //IEnumerable<ProductVM> GetProductByType(int pizzaId);
        List<ProductVM> GetProductByType(ProductTypes product);


        int CreateProduct(ProductVM model);
        int RemoveProduct(int productId);
        
    }
}
