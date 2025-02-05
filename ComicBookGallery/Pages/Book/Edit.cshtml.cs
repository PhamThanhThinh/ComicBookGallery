using ComicBookGallery.DAL;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComicBookGallery.Pages.Book
{
  public class EditModel : PageModel
  {
    private readonly ApplicationDbContext _context;

    public EditModel(ApplicationDbContext context)
    {
      _context = context;
    }

    [BindProperty]
    public Books Books { get; set; } = default;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
      if (id == null)
      {
        return RedirectToPage("./Index");
      }

      var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
      if (book == null)
      {
        return RedirectToPage("./Index");
      }
      Books = book;
      return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }

      _context.Update(Books);
      await _context.SaveChangesAsync();
      return Page();
    }

  }
}
