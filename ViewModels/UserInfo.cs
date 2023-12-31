using System.ComponentModel.DataAnnotations;

namespace CyberStore.ViewModels;

 public class UserInfo
{
    public string? Id {get; set;}
    [Required(ErrorMessage = "Please enter a username.")]
    public string? UserName {get; set;}
    [EmailAddress]
    public string? Email {get; set;}
    [Required(ErrorMessage = "Please enter a password.")]
    [DataType(DataType.Password)]
    public string? Password {get; set;}
    [Phone(ErrorMessage = "Please provide a valid phone number.")]
    public string? PhoneNumber {get; set;}
    public bool? TwoFactorEnabled {get; set;}
    [Required(ErrorMessage = "Please select at least one role.")]
    public List<string>? Roles {get; set;}
}