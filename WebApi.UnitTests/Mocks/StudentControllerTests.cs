using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;
using WebApi.Data.Entities;

namespace WebApi.UnitTests.Mocks
{
    public class StudentControllerTests
    {
        [Fact]
        public void WhenGettingAllStudents_ThenAllStudentsReturn()
        {
            var repositoryWrapperMock = MockIRepositoryWrapper.GetMock();
           // var mapper = GetMapper();
           // var logger = new LoggerManager();
            var studentsController = new StudentsController( repositoryWrapperMock.Object);

            var result = studentsController.GetAllStudents() as ObjectResult;
            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
            Assert.IsAssignableFrom<IEnumerable<Students>>(result.Value);
            Assert.NotEmpty(result.Value as IEnumerable<Students>);
        }
        [Fact]
        public void GivenAnIdOfAnExistingStudent_WhenGettingStudentById_ThenStudentReturns()
        {
            var repositoryWrapperMock = MockIRepositoryWrapper.GetMock();
           // var mapper = GetMapper();
           // var logger = new LoggerManager();
            var studentsController = new StudentsController( repositoryWrapperMock.Object);
            int id = 2;
            var result = studentsController.GetStudentById(id) as ObjectResult;
            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
            Assert.IsAssignableFrom<Students>(result.Value);
            Assert.NotNull(result.Value as Students);
        }
    }
}
