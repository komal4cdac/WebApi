using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Contracts;
using WebApi.Contracts.RepositoryWrapper;
using WebApi.Data.Entities;

namespace WebApi.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        //private MyWorldDbContext _repoContext;
        //private IStudentRepository _student;
        //public RepositoryWrapper(MyWorldDbContext  myWorldDbContext)
        //{
        //    _repoContext = myWorldDbContext;
        //}
        //public IStudentRepository Employee
        //{
        //    get
        //    {
        //        if (_student == null)
        //        {
        //            _student = new StudentRepository(_repoContext);
        //        }
        //        return _student;
        //    }
        //}
       
       
        //public void Save()
        //{
        //    _repoContext.SaveChanges();
        //}


        private EmployeeDbContext _repoContext;
        private IEmployeeRepository _owner;
       
        public IEmployeeRepository Employee
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new StudentRepository(_repoContext);
                }
                return _owner;
            }
        }
       
        public RepositoryWrapper(EmployeeDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
