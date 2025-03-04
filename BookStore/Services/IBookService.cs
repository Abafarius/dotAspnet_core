using BookStore.Models;

namespace BookStore.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        void AddBook(Book book);
    }
}
