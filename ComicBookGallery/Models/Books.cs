using System.ComponentModel.DataAnnotations;

namespace ComicBookGallery.Models
{
  // code first
  // đặt tên Bảng dữ liệu bằng DisplayColumn
  //[DisplayColumn("Book")]
  public class Books
  {
    //id tự động tăng
    [Key]
    public int Id { get; set; }
    
    [Required]
    [Display(Name = "Tiêu đề cuốn sách")]
    public string BookTitle { get; set; }
    public string BookDescription { get; set; }
    [Required]
    public string Author { get; set; }


  }
}
