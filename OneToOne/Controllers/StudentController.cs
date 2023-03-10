using Microsoft.AspNetCore.Mvc;
using OneToOne.Models;
using OneToOne.Service;

namespace OneToOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private IStudentService _studentsService;

        public StudentController(IStudentService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpPost]
        public ActionResult<short> CreateStudent(Student student)
        {
            _studentsService.AddStudent(student);
            return Ok(student);
        }

    }
}
