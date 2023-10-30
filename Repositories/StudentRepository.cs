using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)//DI Pattern 
        {
            this.db = db;
        }
        public int AddStudent(Student stud)
        {
            // added the book object in the DBSet
            db.Students.Add(stud);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int DeletStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Rno == id).FirstOrDefault();
            if (result != null)
            {
                db.Students.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public IEnumerable<Student> GetStudent()
        {
            return db.Students.ToList();
        }

        public Student GetStudentByRno(int id)
        {
            var result = db.Students.Where(x => x.Rno == id).SingleOrDefault();
            return result;

        }

        public int UpdateStudent(Student stud)
        {
            int res = 0;
            // find the record from Dbset that we need to modify
            //var result = (from b in db.Books
            //             where b.Id == book.Id
            //             select b).FirstOrDefault();

            var result = db.Students.Where(x => x.Rno == stud.Rno).FirstOrDefault();

            if (result != null)
            {
                result.Name = stud.Name; // book contains new data, result contains old data
                result.City = stud.City;
                result.Per = stud.Per;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
