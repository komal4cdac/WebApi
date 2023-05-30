using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Contracts.RepositoryWrapper;
using WebApi.Data.Entities;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepositoryWrapper repository;
        public EmployeeController(IRepositoryWrapper repositoryWrapper)
        {
            repository= repositoryWrapper;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var employees = repository.Employee.FindAll();

            return Ok(employees);
           
        }
        [HttpGet]
        public IActionResult GetStudentById(int Id)
        {
            var employees = repository.Employee.GetStudentById(Id);
                
            return Ok(employees);

        }


    }
}
