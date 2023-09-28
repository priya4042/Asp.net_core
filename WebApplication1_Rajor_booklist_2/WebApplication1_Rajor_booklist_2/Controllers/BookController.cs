using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1_Rajor_booklist_2.Data;

namespace WebApplication1_Rajor_booklist_2.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public BookController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        //[HttpGet]

        //public IActionResult GetAll()
        //{
        //    var BookList = _context.Books.ToList();
        //    return Json(new { data = BookList });
        //}
        //[HttpDelete]

        //public IActionResult Delete(int id)
        //{
        //    var BookFromDb = _context.Books.Find(id);
        //    if (BookFromDb == null)
        //        return Json(new { success = false, message = "Error While Delete data!!!" });
        //    _context.Books.Remove(BookFromDb);
        //    _context.SaveChanges();
        //    return Json(new { success = true, message = "Data Successfuly Deleted" });
        //}

        //public ApplicationDbContext context;
        //public BookController(ApplicationDbContext dbContext)
        //{
        //    context = dbContext;
        //}
        //[HttpGet]

        //public IActionResult GetAll()
        //{
        //    var booktodb = context.Books.ToList();
        //    return Json(new { data = booktodb });
        //}

        //[HttpDelete]

        //public IActionResult Delete(int id)
        //{
        //    var bookfromdb = context.Books.Find(id);
        //    if (bookfromdb == null)
        //        return Json(new { success = false, message = "error ehile delete data" });
        //    context.Books.Remove(bookfromdb);
        //    context.SaveChanges();
        //    return Json(new { success = true, message = "Data deleted successfully" });
        //}


        //public ApplicationDbContext _context;
        //public BookController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        //[HttpPost]

        //public IActionResult GetAll()
        //{
        //    var bookInDb = _context.Books.ToList();
        //    return  Json(new { Data=bookInDb });
        //}
        //[HttpDelete]

        //public IActionResult Delete(int id)
        //{
        //    var boofromdb = _context.Books.Find(id);
        //    if (boofromdb == null)
        //        return Json(new { success = false, message = "Error When Deleteing messgae" });
        //    _context.Books.Remove(boofromdb);
        //    _context.SaveChanges();
        //    return Json(new{success=true,message="Message Deleted Successfully" });
        //}

        //public ApplicationDbContext _context;
        //public BookController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        //[HttpPost]

        //public IActionResult GetAll()
        //{
        //    var bookTodb = _context.Books.ToList();
        //    return Json(new { Data = bookTodb });

        //}
        //[HttpDelete]

        //public IActionResult Delete( int id)
        //{
        //    var boofromdb = _context.Books.Find(id);
        //    if (boofromdb == null)
        //        return Json(new { success = false, message = "Error while deleting data!!!" });
        //    _context.Books.Remove(boofromdb);
        //    _context.SaveChanges();
        //    return Json(new { success = true, message = "Data deleted successfully" });
        //}



        //private readonly ApplicationDbContext dbContext;
        //public BookController(ApplicationDbContext Context)
        //{
        //    dbContext = Context;
        //}
        //[HttpGet]

        //public IActionResult GetAll()
        //{
        //    var booktodb = dbContext.Books.ToList();
        //    return Json(new { Data = booktodb });
        //}
        //[HttpDelete]

        //public IActionResult Delete(int id)
        //{
        //    var bookfromdb = dbContext.Books.Find(id);
        //    if (bookfromdb == null)
        //        return Json(new { success = false, message = "Error When deleting the message" });
        //    dbContext.Books.Remove(bookfromdb);
        //    dbContext.SaveChanges();
        //    return Json(new { success = true, message = "Data Deleted succesfully" });
        //}

        private readonly ApplicationDbContext dbContext;
        public BookController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var BookToDb = dbContext.Books.ToList();
            return Json(new { Data = BookToDb });
        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var BookFromDb = dbContext.Books.Find(id);
            if (BookFromDb == null)
                return Json(new { success = false, message = "Error While Deleting the data" });
            dbContext.Books.Remove(BookFromDb);
            dbContext.SaveChanges();
            return Json(new { success = true, message = "Data successfully deleted" });
        }

    }
}
