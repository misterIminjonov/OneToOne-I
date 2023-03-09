using OneToOne.Models;

namespace OneToOne.Service
{
    public class StudentsService
    {
        private SchoolDbContext _context;

        public StudentsService(SchoolDbContext context)
        {
            _context = context;
        }

        public short AddStudent(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();

            return student.Id;
        }
        public short AddStudent(StudentAddres studentAddres)
        {
            _context.studentsAddres.Add(studentAddres);
            _context.SaveChanges();
            return studentAddres.StudentAddressId;
        }
    }
}
