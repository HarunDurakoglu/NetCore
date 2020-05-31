using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
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
            
        }
        public IResult AddMobile(Product product)
        {
            //Business codes
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }
        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
        public IResult DeleteMobile(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Ürün Başarıyla Silindi");
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }
        public IDataResult<List<Product>> GetAllMobile()
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetList().ToList());
        }
        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetList(p=>p.CategoryId==categoryId);
        }
        public IDataResult<List<Product>> GetByCategoryIdMobile(int categoryId)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId));
        }
        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }
        public IDataResult<Product> GetByIdMobile(int productId)
        {
            return new SuccesDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
        public IResult UpdateMobile(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün Başarıyla Güncellendis");
        }
    }
}
