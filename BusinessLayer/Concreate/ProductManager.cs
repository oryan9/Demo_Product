using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

  
        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetList();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TUbdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
