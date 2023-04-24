using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly MyTestDBContext _myWorldDbContext;
        public StudentsController(MyTestDBContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var students = await _myWorldDbContext.Students.ToListAsync();
            return Ok(students);
        }


    }
}
