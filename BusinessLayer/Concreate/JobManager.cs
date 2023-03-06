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
    public class JobManager : IJobService

    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void TDelete(Job t)
        {
            _jobDal.Delete(t);
        }

        public List<Job> TGetAll()
        {
            return _jobDal.GetList();
        }

        public Job TGetById(int id)
        {
            return _jobDal.GetById(id);
        }

        public void TInsert(Job t)
        {
            _jobDal.Insert(t);
        }

        public void TUbdate(Job t)
        {
            _jobDal.Update(t);
        }
    }
}
