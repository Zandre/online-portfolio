using System.ComponentModel.DataAnnotations;

namespace OnlinePortfolioZB.Models
{
    public class ContactMeMessage
    {
        [Required]
        [Display(Name = "Message", Prompt = "Hi Zandré, ...")]
        public string Message { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "johndoe@gmail.com")]
        public string Email { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Full Name", Prompt = "John Doe")]
        public string Name { get; set; }
    }
}
    