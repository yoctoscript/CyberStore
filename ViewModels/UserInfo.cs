namespace CyberStore.ViewModels;

 public class UserInfo
{
    public string Id {get; set;} = string.Empty;
    public string UserName {get; set;} = string.Empty;
    public string Email {get; set;} = string.Empty;
    public string? Password {get; set;} = string.Empty;
    public string PhoneNumber {get; set;} = string.Empty;
    public bool TwoFactorEnabled {get; set;}
    public IList<string> Roles {get; set;} = new List<string>();
}