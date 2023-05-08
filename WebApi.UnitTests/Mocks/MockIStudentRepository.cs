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
    internal class MockIStudentRepository
    {
        public static Mock<IStudentRepository> GetMock()
        {
            var mock = new Mock<IStudentRepository>();
            var students = new List<Students>()
        {
            new Students()
            {
                Id= 1,
                Age=20,
                FirstName="komal",
                Gender="F",
                LastName="narkhede"

            },
            new Students()
            {
                Id= 2,
                Age=22,
                FirstName="viva",
                Gender="F",
                LastName="jadhav"

            }
        };
            mock.Setup(m => m.FindAll())
                    .Returns(() => students);
            mock.Setup(m => m.GetStudentById(It.IsAny<int>()))
             .Returns((int id) => students.FirstOrDefault(o => o.Id == id));
            return mock;
        }
    }
}
