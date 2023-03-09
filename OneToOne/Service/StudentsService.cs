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

        public short AddStudent(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();

            return student.Id;
        }

        public Student UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
