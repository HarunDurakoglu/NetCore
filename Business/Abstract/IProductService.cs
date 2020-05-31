using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        Product GetById(int productId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

        IDataResult<List<Product>> GetAllMobile();
        IDataResult<List<Product>> GetByCategoryIdMobile(int categoryId);
        IDataResult<Product> GetByIdMobile(int productId);
        IResult AddMobile(Product product);
        IResult DeleteMobile(Product product);
        IResult UpdateMobile(Product product);

    }
}
