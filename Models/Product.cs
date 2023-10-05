using System.ComponentModel.DataAnnotations;

namespace CyberStore.Models;

public class Product
{
    [Key]
    public Guid? Id {get; set;}
    [Required(ErrorMessage = "Please provide a product name.")]
    public string? Name {get; set;}
    [Required(ErrorMessage = "Please provide a product description.")]
    public string? Description {get; set;}
    [Required(ErrorMessage = "Please provide a valid price.")]
    [DataType(DataType.Currency)]
    [Range(0.0f, float.MaxValue)]
    public float? Price {get; set;}
    [Required(ErrorMessage = "Please specify a category for the product.")]
    public string? Category {get; set;}
    [Required(ErrorMessage = "Please provide an image URL for the product.")]
    public string? Image {get; set;}
    [Required(ErrorMessage = "Please provide an SKU for the product.")]
    public string? SKU {get; set;}
    [Required(ErrorMessage = "Please specify the brand of the product.")]
    public string? Brand {get; set;}
    public List<Feedback>? Feedbacks {get; set;}
    [Required(ErrorMessage = "Please indicate whether the product is available.")]
    public bool? IsAvailable {get; set;}

    public class Tag
    {
        [Key]
        public Guid Id {get; set;}
        public string Name {get; set;} = string.Empty;
    }
    public class Feedback
    {
        [Key]
        public Guid Id {get; set;}
        public float Rating {get; set;}
        public string Review {get; set;} = string.Empty;
    }
}