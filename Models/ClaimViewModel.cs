using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System.Models
{
    public class ClaimViewModel
    {
        public string Username { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal Rate { get; set; }
        public string Period { get; set; }
    }
}
