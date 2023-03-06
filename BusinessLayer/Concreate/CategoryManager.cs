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
    public class CategoryManager : ICategoryService

    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetList();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TUbdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
