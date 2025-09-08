using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System.Models { 
public class RegisterViewModel
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    }
}
