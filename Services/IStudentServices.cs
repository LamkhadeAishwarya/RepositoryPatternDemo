using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IStudentServices
    {
        IEnumerable<Student> GetStudent();
        Student GetStudentByRno(int id);
        int AddStudent(Student stud);
        int UpdateStudent(Student stud);
        int DeletStudent(int id);
    }
}
