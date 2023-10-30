using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IBookServices
    {
        IEnumerable<Book>GetBooks();
        Book GetBookById(int id);
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int id);

    }
}
