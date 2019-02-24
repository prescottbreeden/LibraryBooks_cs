using System.ComponentModel.DataAnnotations;

namespace LibraryBooks.Models
{
  public class Book
  {
    public int BookId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Author { get; set; }
    [Range(1000, 2019)]
    public int ReleaseYear { get; set; }
    public Book() { }
    public Book(int bookId, string title, string author, int releaseYear)
    {
      BookId = bookId;
      Title = title;
      Author = author;
      ReleaseYear = releaseYear;
    }
  }
}