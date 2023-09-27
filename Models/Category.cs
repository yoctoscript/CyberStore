using System.ComponentModel.DataAnnotations;

namespace CyberStore.Models;

public class Category
{
    [Key]
    public Guid Id {get; set;}
    public string Name {get; set;} = string.Empty;
    
}
