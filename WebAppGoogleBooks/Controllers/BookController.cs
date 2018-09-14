using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppGoogleBooks.Models.Repositories;
using WebAppGoogleBooks.Models.ViewModels; 

namespace WebAppGoogleBooks.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository; 

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository; 

        }


        // GET: Book
        public ActionResult Index()
        {
            return View(new BookViewModel {
                Books = _bookRepository.GetBooks()
            });
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View(new BookDetailsViewModel {
                 Book = _bookRepository.GetBook(id)   
            });
        }

        //// GET: Book/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Book/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Book/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Book/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Book/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Book/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}