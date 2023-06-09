using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Quote
{
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Author { get; set; }
    [Required] 
    public string QuoteText { get; set; }
}