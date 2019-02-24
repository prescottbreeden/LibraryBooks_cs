using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryBooks.Models;

namespace LibraryBooks.Controllers
{
  public class HomeController : Controller
  {
    //....................................................................//
    // Some default properties provided that can be accessed inside your  // 
    // controller methods so you have data to work with - this data will  //
    // persist until you restart the server - the CreateBookId is a       // 
    // property that will provide an incremented Id when adding a new     //
    // book to the hardcoded data.                                        //
    //....................................................................//
    private static BookLibrary Library { get; set; } = new BookLibrary();
    private static User Lisa = new User("Lisa", "Simpson");
    private static int CreateBookId => Library.Books.Count + 1;

    [HttpGet("")]
    public IActionResult Index()
    {
      return View(new Dashboard(Lisa, Library));
    }

    [HttpGet("checkout/{bookId}")]
    public IActionResult Add(int bookId)
    {
      Book checkout = Library.Books.FirstOrDefault(b => b.BookId == bookId);
      Lisa.Books.Add(checkout);
      Library.Books.Remove(checkout);
      return RedirectToAction("Index");
    }

    [HttpGet("return/{bookId}")]
    public IActionResult Remove(int bookId)
    {
      Book returningBook = Lisa.Books.FirstOrDefault(b => b.BookId == bookId);
      Lisa.Books.Remove(returningBook);
      Library.Books.Add(returningBook);
      return RedirectToAction("Index");
    }

    [HttpPost("newbook")]
    public IActionResult NewBook(Book book)
    {
      if (ModelState.IsValid)
      {
        book.BookId = CreateBookId;
        Library.Books.Add(book);
        return RedirectToAction("Index");
      }
      return View("Index", new Dashboard(Lisa, Library));
    }
  }
}
