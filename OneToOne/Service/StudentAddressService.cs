using OneToOne.Models;

namespace OneToOne.Service
{
    public class StudentAddressService : IStudentAddressService
    {
        private readonly SchoolDbContext _context;

        public StudentAddressService(SchoolDbContext context)
        {
            _context = context;
        }

        public short AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public short AddStudentAddress(StudentAddress studentAddress)
        {
            _context.StudentAddress.Add(studentAddress);
            _context.SaveChanges();
            return studentAddress.AddressId;
        }

        public int DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudentAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public StudentAddress GetStudentAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public StudentAddress UpdateStudentAddress(int id, StudentAddress studentAddress)
        {
            throw new NotImplementedException();
        }
    }
}
