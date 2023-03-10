using OneToOne.Models;

namespace OneToOne.Service
{
    public class StudentsService : IStudentService
    {
        private readonly SchoolDbContext _context;

        public StudentsService(SchoolDbContext context)
        {
            _context = context;
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student AddStudent(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        short IStudentService.AddStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
