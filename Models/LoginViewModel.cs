using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System.Models
{
        public class LoginViewModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
}
