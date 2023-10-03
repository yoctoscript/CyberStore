using System.ComponentModel.DataAnnotations;

namespace CyberStore.Models;

public class Product
{
    [Key]
    public Guid? Id {get; set;}
    [Required]
    public string? Name {get; set;}
    [Required]
    public string? Description {get; set;}
    [Required]
    [DataType(DataType.Currency)]
    [Range(0.0f, float.MaxValue)]
    public float? Price {get; set;}
    [Required]
    public string? Category {get; set;}
    [Required]
    public string? Image {get; set;}
    [Required]
    public string? SKU {get; set;}
    [Required]
    public string? Brand {get; set;}
    public List<Feedback>? Feedbacks {get; set;}
    [Required]
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