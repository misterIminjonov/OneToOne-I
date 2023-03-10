using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneToOne.Models;
using OneToOne.Service;

namespace OneToOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdressController : ControllerBase
    {
        private IStudentAddressService _studentAddresService;

        public StudentAdressController(IStudentAddressService studentAddressService)
        {
            _studentAddresService = studentAddressService;
        }
        [HttpPost]
        public ActionResult<short> CreateStudentAddress(StudentAddress studentAddress)
        {
            _studentAddresService.AddStudentAddress(studentAddress);

            return Ok(studentAddress);
        }
    }
}
