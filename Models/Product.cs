using System.ComponentModel.DataAnnotations;

namespace CyberStore.Models;

public class Product
{
    [Key]
    public Guid Id {get; set;}
    [Required]
    [MinLength(5, ErrorMessage = "Too short of a name")]
    [MaxLength(75)]
    public string Name {get; set;} = string.Empty;
    [Required]
    [MinLength(5, ErrorMessage = "Too short of a description")]
    [MaxLength(75)]
    public string Description {get; set;} = string.Empty;
    [Required]
    public float Price {get; set;}
    [Required]
    public Category Category {get; set;} = new();
    [Required]
    public List<Image> Images {get; set;} = new();
    public string SKU {get; set;} = string.Empty;
    public string Brand {get; set;} = string.Empty;
    public List<Feedback> Feedbacks {get; set;} = new();
    public List<Tag> Tags {get; set;} = new();
    public bool IsAvailable {get; set;}

    public class Image
    {
        [Key]
        public Guid Id {get; set;}
        public string Url {get; set;} = string.Empty;
    }
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