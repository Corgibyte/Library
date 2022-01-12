using System.Collections.Generic;
using System;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      // this.Copies = new HashSet<Copy>(); this.Copies = new HashSet<Copy>();
    }

    public int BookId { get; set; }
    public string Title { get; set; }
    public virtual ApplicationUser User { get; set; }
    
    public virtual ICollection<AuthorBook> Authors { get; set; }
  }
}

