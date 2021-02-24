using AutoMapper;
using IdealDesign_DataAccess.Interfaces;
using IdealDesign_Domain.Enums;
using IdealDesign_Domain.Models;
using IdealDesign_Services.Interfaces;
using IdealDesign_WebModels.EnumsVM;
using IdealDesign_WebModels.VewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdealDesign_Services.Services
{
    public class ProductService : IProductService
    {
        protected readonly IRepository<Product> _productRepo;
        protected readonly IMapper _mapper;
        public ProductService(IRepository<Product> productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }        

        public IEnumerable<ProductVM> GetAllProducts()
        {

            return _mapper.Map<List<Product>, List<ProductVM>>(_productRepo.GetAll().ToList());
        }

        public ProductVM GetProductById(int id)
        {
            Product product = _productRepo.GetById(id);
            ProductVM model = _mapper.Map<ProductVM>(product);
            if(model != null)
            {
                return model;
            }
            else
            {
                throw new Exception($"Product with id: {id} does not exist");
            }
        }

        public List<ProductVM> GetProductByType(ProductTypes type)
        {
            try
            {                
                var products = _productRepo.GetAll().Where(x => x.ProductType == type).ToList();               
                return _mapper.Map<List<Product>, List<ProductVM>>(products);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
            
           
        }
        public int CreateProduct(ProductVM model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Name) || model.Name.Count() < 3)
                {
                    throw new Exception("Can not be empty field!");
                }
                if (string.IsNullOrEmpty(model.Description) || model.Description.Count() < 3)
                {
                    throw new Exception("Can not be empty field!");
                }
                var mappedProduct = _mapper.Map<Product>(model);
                return _productRepo.Insert(mappedProduct);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        public int RemoveProduct(int productId)
        {
            try
            {
                var product = _productRepo.GetById(productId);
                if (product == null)
                {
                    throw new Exception($"There is not product with id {productId}");
                }
                return _productRepo.Delete(productId);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

       
    }
}
