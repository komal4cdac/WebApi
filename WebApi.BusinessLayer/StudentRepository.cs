﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Contracts;
using WebApi.Data.Entities;

namespace WebApi.Repository
{
    public class StudentRepository : RepositoryBase<Students>, IStudentRepository
    {
        public StudentRepository(MyWorldDbContext myWorldDBContext)
            : base(myWorldDBContext)
        {

        }

        public void FindByCondition(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Students GetStudentById(int Id)
        {
            return FindByCondition(owner => owner.Id.Equals(Id))
                .FirstOrDefault();
        }
    }
}