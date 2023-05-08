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
        //public IStudentRepository Student
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


        private MyWorldDbContext _repoContext;
        private IStudentRepository _owner;
       
        public IStudentRepository Student
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
       
        public RepositoryWrapper(MyWorldDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
