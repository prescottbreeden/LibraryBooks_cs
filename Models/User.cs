using System;
using System.Collections.Generic;

namespace LibraryBooks.Models
{
  public class User
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();
    public User(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }
  }
}