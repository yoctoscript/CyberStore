using System.ComponentModel.DataAnnotations.Schema;

namespace CyberStore.Models;

public class Product
{
    public Guid Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public float Price {get; set;}
    public Category Category {get; set;} = new();
    [NotMapped]
    public List<string> Images {get; set;} = new();
    public string SKU {get; set;} = string.Empty;
    public string Brand {get; set;} = string.Empty;
    [NotMapped]
    public List<float> Ratings {get; set;} = new();
    [NotMapped]
    public List<string> Reviews {get; set;} = new();
    [NotMapped]
    public List<string> Tags {get; set;} = new();
    public bool IsAvailable {get; set;}
}