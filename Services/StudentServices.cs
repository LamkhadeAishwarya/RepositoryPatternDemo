using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repositories;

namespace RepositoryPatternDemo.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository repo;
        public StudentServices(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student stud)
        {
            return repo.AddStudent(stud);
        }

        public int DeletStudent(int id)
        {
            return (repo.DeletStudent(id));
        }

        public IEnumerable<Student> GetStudent()
        {
           return repo.GetStudent();
        }

        public Student GetStudentByRno(int id)
        {
            return repo.GetStudentByRno(id);
        }

        public int UpdateStudent(Student stud)
        {
            return repo.UpdateStudent(stud);
        }
    }
}
