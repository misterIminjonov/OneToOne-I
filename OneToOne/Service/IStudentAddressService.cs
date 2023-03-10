using OneToOne.Models;

namespace OneToOne.Service
{
    public interface IStudentAddressService
    {
        public StudentAddress GetStudentAddress(int id);
        public short AddStudentAddress(StudentAddress studentAddress);
        public StudentAddress UpdateStudentAddress(int id, StudentAddress studentAddress);
        public int DeleteStudentAddress(int id);

    }
}
