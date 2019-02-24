using System.Collections.Generic;

namespace LibraryBooks.Models
{
  public class BookLibrary
  {
    public List<Book> Books { get; set; } = new List<Book>()
    {
      new Book(1, "Hamlet", "Bill Shakespeare", 1602),
      new Book(2, "Moby Dick", "Hermit Melville", 1851),
      new Book(3, "Frankenstein", "Merry Shelly", 1818),
      new Book(4, "Lord of the Rings", "J.R.R. Token", 1954),
      new Book(5, "Harry Potter", "J.K. Bowling", 1998)
    };
    public Book Book { get; set; }
  }
}