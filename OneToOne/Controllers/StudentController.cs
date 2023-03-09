using Microsoft.AspNetCore.Mvc;
using OneToOne.Models;
using OneToOne.Service;

namespace OneToOne.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private StudentsService _studentsService;

        public StudentController(StudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpPost]
        public ActionResult<short> CreatStudent(Student student/*, StudentAddres studentAddres*/)
        {
            _studentsService.AddStudent(student);
            //  _studentsService.AddStudentt(studentAddres);

            return Ok(student);
        }

    }
}
