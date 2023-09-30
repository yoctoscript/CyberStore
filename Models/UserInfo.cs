namespace CyberStore.Models;

 public class UserInfo
{
    public string UserName {get; set;} = string.Empty;
    public string Email {get; set;} = string.Empty;
    public string? Password {get; set;} = string.Empty;
    public IList<string> Roles {get; set;} = new List<string>();
}