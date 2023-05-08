using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Entities;

namespace WebApi.Contracts
{
    public interface IStudentRepository : IRepositoryBase<Students>
    {
        public Students GetStudentById(int Id);
        void FindByCondition(Guid guid);
    }

}
