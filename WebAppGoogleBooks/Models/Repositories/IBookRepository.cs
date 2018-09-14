using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppGoogleBooks.Models.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        void AddOrUpdate(Book book);
        void Delete(Book book); 
    }
}
