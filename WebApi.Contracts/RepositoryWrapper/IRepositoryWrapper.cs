using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Contracts.RepositoryWrapper
{
    public interface IRepositoryWrapper
    {
        IStudentRepository Student { get; }
      
        void Save();
    }
}
