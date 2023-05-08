using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Contracts.RepositoryWrapper;
using WebApi.Data.Entities;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IRepositoryWrapper repository;
        public StudentsController(IRepositoryWrapper repositoryWrapper)
        {
            repository= repositoryWrapper;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = repository.Student.FindAll();

            return Ok(students);
           
        }
        [HttpGet]
        public IActionResult GetStudentById(int Id)
        {
            var students = repository.Student.GetStudentById(Id);
                
            return Ok(students);

        }


    }
}
