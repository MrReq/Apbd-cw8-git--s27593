using System.ComponentModel.DataAnnotations;

namespace Apbd_cw8_git__s27593.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }
    
    [Required]
    public int Isbn { get; set; }
    
    
    public int PublishedYear { get; set; }
    
    
    public int AuthorId { get; set; }
}