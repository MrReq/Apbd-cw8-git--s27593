namespace Apbd_cw8_git__s27593.Models;


public class Borrowing
{
    public int Id { get; set; }
    
    public int BookId { get; set; }
    
    public string BorrowerName { get; set; }
    
    public DateTime BorrowAt { get; set; }
    
    public DateTime ReturnAt { get; set; }
}