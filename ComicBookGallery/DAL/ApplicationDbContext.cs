using ComicBookGallery.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicBookGallery.DAL
{
  public class ApplicationDbContext:DbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Books> Books { get; set; }
  }
}
