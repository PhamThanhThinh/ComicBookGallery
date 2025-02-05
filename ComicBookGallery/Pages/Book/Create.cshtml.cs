using ComicBookGallery.DAL;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ComicBookGallery.Pages.Book
{
  public class CreateModel : PageModel
  {
    private readonly ApplicationDbContext _context;

    public CreateModel(ApplicationDbContext context)
    {
      _context = context;
    }

    public IActionResult OnGet()
    {
      return Page();
    }

    [BindProperty]
    public Books Books { get; set; } = default;

    public async Task<IActionResult> OnPostAsync()
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }

      _context.Books.Add(Books);
      await _context.SaveChangesAsync();
      //return Page();
      return RedirectToPage("./Index");
    }
  }
}
