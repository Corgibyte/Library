using System;
using System.Collections.Generic;

namespace Library.Models
{
  public class Checkout
  {
    public int CheckoutId { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsReturned { get; set; }
    public int CopyId { get; set; }
    public virtual Copy Copy { get; set; }
  }
}