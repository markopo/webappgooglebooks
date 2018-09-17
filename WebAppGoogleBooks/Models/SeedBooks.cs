using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppGoogleBooks.Models.Repositories;
using GoogleBooksRetriever;
using System.Threading;
using GoogleBooksDAL.Models;

namespace WebAppGoogleBooks.Models
{
    public static class SeedBooks
    {


        public static void Init(IServiceProvider serviceProvider)
        {
          
            var bookRepo = serviceProvider.GetRequiredService<IBookRepository>();
            var errorLogRepo = serviceProvider.GetRequiredService<IErrorlogRepository>(); 
            var hasBooks = bookRepo.GetBooks().Any();

            if (hasBooks)
            {
                return;
            }

            MakeSearches(bookRepo, errorLogRepo); 
        }

        private static void MakeSearches(IBookRepository bookRepo, IErrorlogRepository errorlogRepo)
        {
            var searchCategories = new string[] { "Android", "Angular", "ASP.NET", "ASP.NET MVC", "C#", "CSS", "iOS", "Javascript", "jQuery", "Knockout.js", "LESS", "MySQL", "PHP", "React", "SASS", "Swift", "Wordpress" };
            foreach (var q in searchCategories)
            {
                try
                {
                    LoadData(q, bookRepo, errorlogRepo);
                    Thread.Sleep(1000);
                }
                catch(Exception ex)
                {
                    errorlogRepo.AddLog(ex); 
                }
            }
        }


        private static void LoadData(string  q, IBookRepository bookRepo, IErrorlogRepository errorlogRepository)
        {
            var result = new FindBooks().Retrieve(q);

            if(!result.Success && string.IsNullOrEmpty(result.ErrorMessage) || result.GoogleBooks.Count() == 0)
            {
                errorlogRepository.AddLog(new Errorlog { Message = result.ErrorMessage, Stacktrace = "", Created = DateTime.Now }); 
            }

            foreach (var gb in result.GoogleBooks)
            {
                Book book = null;

                try
                {
                    book = new Book
                    {
                        Title = gb.Title ?? "",
                        ItemId = gb.ItemId ?? "",
                        SubTitle = gb.SubTitle ?? "",
                        Publisher = gb.Publisher ?? "",
                        PublishedDate = gb.PublishedDate ?? "",
                        Description = gb.Description ?? "",
                        PageCount = gb.PageCount ?? "",
                        PrintType = gb.PrintType ?? "",
                        AverageRating = gb.AverageRating ?? "",
                        ThumbNail = gb.ThumbNail ?? "",
                        Language = gb.Language ?? "",
                        CanonicalVolumeLink = gb.CanonicalVolumeLink ?? "",
                        WebReaderLink = gb.WebReaderLink ?? "",
                        ISBN10 = gb.ISBN10 ?? "",
                        ISBN13 = gb.ISBN13 ?? "",
                        Created = DateTime.Now,
                        Updated = DateTime.Now
                    };

                }
                catch(Exception exception)
                {
                    errorlogRepository.AddLog(exception); 
                }


                try
                {
                    var authors = gb.Authors;

                    if (authors != null && authors.Length > 0)
                    {
                        foreach (var author in authors.Select(a => new Author
                        {
                            Name = a,
                            Created = DateTime.Now,
                            Updated = DateTime.Now
                        }))
                        {
                            book.AddAuthor(author);
                        }
                    }
                }
                catch(Exception exception)
                {
                    errorlogRepository.AddLog(exception); 
                }


                try
                {
                    var categories = gb.Categories;

                    if (categories != null && categories.Length > 0)
                    {
                        foreach (var category in categories.Select(c => new Category
                        {
                            Name = c,
                            Created = DateTime.Now,
                            Updated = DateTime.Now
                        }))
                        {
                            book.AddCategory(category);
                        }
                    }
                }
                catch(Exception exception)
                {
                    errorlogRepository.AddLog(exception); 
                }


                if (book != null)
                {
                    bookRepo.AddOrUpdate(book);
                }

            }
        }
    }
}
