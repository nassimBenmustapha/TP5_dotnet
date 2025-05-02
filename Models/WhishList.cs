namespace TP5.Models;

public class WhishList
{
    public Guid Id { get; set; }
    public string UserID { get; set; }
    public Guid MovieID { get; set; }
    public ApplicationUser? User { get; set; }
    
    
    public Movie Movie { get; set; }
}