using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Library.Controllers
{
  public class CopiesController : Controller
  {
    private readonly LibraryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public CopiesController(UserManager<ApplicationUser> userManager, LibraryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Delete(int id)
    {
      Copy thisCopy = _db.Copies.FirstOrDefault(copy => copy.CopyId == id);
      return View(thisCopy);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Copy thisCopy = _db.Copies.FirstOrDefault(copy => copy.CopyId == id);
      _db.Copies.Remove(thisCopy);
      _db.SaveChanges();
      return RedirectToAction("Details", "Books", new { id = thisCopy.BookId });
    }

    [Authorize]
    public ActionResult CheckoutCopy(int id)
    {
      return View(_db.Copies.FirstOrDefault(copy => copy.CopyId == id));
    }

    [Authorize, HttpPost]
    public async Task<ActionResult> CheckoutCopy(Copy copy)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      DateTime dueDate = DateTime.Now + new TimeSpan(14, 0, 0, 0); 
      Checkout newCheckout = new Checkout() { CopyId = copy.CopyId, IsReturned = false, DueDate = dueDate };
      newCheckout.User = currentUser;
      _db.Checkouts.Add(newCheckout);
      _db.SaveChanges();
      return RedirectToAction("Details", "Books", new { id = copy.Book.BookId });
    }
  }
}