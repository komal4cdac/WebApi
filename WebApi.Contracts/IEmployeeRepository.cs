using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Entities;

namespace WebApi.Contracts
{
    public interface IEmployeeRepository : IRepositoryBase<Employees>
    {
        public Employees GetStudentById(int Id);
        void FindByCondition(Guid guid);
    }

}
