using OneToOne.Models;

namespace OneToOne.Service
{
    public interface IStudentService
    {
        public Student GetStudent(int id);
        public short AddStudent(Student student);
        public Student UpdateStudent(int id, Student student);
        public int DeleteStudent(int id);
    }
}
