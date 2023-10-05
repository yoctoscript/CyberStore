using System.ComponentModel.DataAnnotations;

namespace CyberStore.Models;

public class ShippingDetails
{
    [Required(ErrorMessage = "Please provide your name.")]
    public string? Name {get; set;}
    [Required(ErrorMessage = "Please enter your shipping address.")]
    public string? Address {get; set;}
    [Required(ErrorMessage = "Please specify the city for delivery.")]
    public string? City {get; set;}
    [Required(ErrorMessage = "Please select your country.")]
    public string? Country {get; set;}
}