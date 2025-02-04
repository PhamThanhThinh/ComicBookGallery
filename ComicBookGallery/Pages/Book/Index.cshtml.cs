using ComicBookGallery.DAL;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComicBookGallery.Pages.Book
{
  public class IndexModel : PageModel
  {
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
      _context = context;
    }

    public IList<Books> Books { get; set; }

    public async Task OnGetAsync()
    {
      Books = await _context.Books.ToListAsync();
    }
  }
}
