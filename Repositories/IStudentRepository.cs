using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudent();
        Student GetStudentByRno(int id);
        int AddStudent(Student stud);
        int UpdateStudent(Student stud);
        int DeletStudent(int id);
    }
}
