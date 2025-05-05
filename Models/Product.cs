using System.ComponentModel.DataAnnotations;

namespace InitShop.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Enter the title")]
    [MinLength(3, ErrorMessage = "The product must contain at least 3 characters")]
    [MaxLength(120, ErrorMessage = "The product must contain a maximum of 120 characters")]
    public string Title { get; set; } = string.Empty;
    
    public string? Description { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Enter the price of the Product")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}