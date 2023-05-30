using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Contracts;
using WebApi.Data.Entities;

namespace WebApi.UnitTests.Mocks
{
    internal class MockIEmployeeRepository
    {
        public static Mock<IEmployeeRepository> GetMock()
        {
            var mock = new Mock<IEmployeeRepository>();
            var employees = new List<Employees>()
        {
            new Employees()
            {
                Id= 1,
                Age=20,
                FirstName="komal",
                Gender="F",
                LastName="narkhede"

            },
            new Employees()
            {
                Id= 2,
                Age=22,
                FirstName="viva",
                Gender="F",
                LastName="jadhav"

            }
        };
            mock.Setup(m => m.FindAll())
                    .Returns(() => employees);
            mock.Setup(m => m.GetStudentById(It.IsAny<int>()))
             .Returns((int id) => employees.FirstOrDefault(o => o.Id == id));
            return mock;
        }
    }
}
