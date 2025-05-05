using System.ComponentModel.DataAnnotations;

namespace InitShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Enter the title")]
    [MinLength(3, ErrorMessage = "The category must contain at least 3 characters")]
    [MaxLength(120, ErrorMessage = "The category must contain a maximum of 120 characters")]
    public string Title { get; set; } = string.Empty;
}