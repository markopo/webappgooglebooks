using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace WebAppGoogleBooks.Models.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        

        public BookRepository(IHostingEnvironment environment) : base(environment)
        {
           

        }

        public List<Book> GetBooks()
        {
            List<Book> books = null; 

            using(ISession session = OpenSession())
            {
                books = session.Query<Book>().ToList();
                session.Close(); 
            }

            return books; 
        }

        public Book GetBook(int id)
        {
            Book book = null;

            using (ISession session = OpenSession())
            {
                book = session.Query<Book>().FirstOrDefault(x => x.Id == id);

                // Categories
                NHibernateUtil.Initialize(book.Categories);

                // Authors 
                NHibernateUtil.Initialize(book.Authors); 

                session.Close(); 
            }

            return book; 
        }

        public void AddOrUpdate(Book book)
        {
            base.AddOrUpdate(book); 

            foreach(var a in book.Authors)
            {
                base.AddOrUpdate(a); 
            }

            foreach(var c in book.Categories)
            {
                base.AddOrUpdate(c); 
            }
        }

        public void Delete(Book book)
        {
            foreach (var a in book.Authors)
            {
                base.Delete(a); 
            }

            foreach (var c in book.Categories)
            {
                base.Delete(c); 
            }

            base.Delete(book); 
        }

     
    }
}
