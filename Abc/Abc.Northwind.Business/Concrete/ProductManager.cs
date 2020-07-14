using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId==0);
        }

        public Product GetById(int productId)
        {
           return _productDal.Get(p => p.ProductId == productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public List<Product> GetByName(string key)
        {

            return _productDal.GetList(p => p.ProductName.Contains(key) || key==null);
        }

        public List<Product> GetByStockAmount(short stockAmount)
        {
            return _productDal.GetList(p => p.UnitsInStock < stockAmount);
        }

        public List<Product> GetMinByPrice()
        {
             
            return _productDal.GetList().OrderBy(p => p.UnitPrice).ToList();
          
        }

        public List<Product> GetMaxByPrice()
        {
            return _productDal.GetList().OrderByDescending(p => p.UnitPrice).ToList();
        }
    }
}
