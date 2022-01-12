using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
  public class Checkout
  {
    public int CheckoutId { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime DueDate { get; set; }
    public bool IsReturned { get; set; }
    public int CopyId { get; set; }
    public virtual Copy Copy { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}