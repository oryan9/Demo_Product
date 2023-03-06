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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetList();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TUbdate(Customer t)
        {
            _customerDal.Update(t);
        }

        public List<Customer> GetCustomerListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }
    }
}
