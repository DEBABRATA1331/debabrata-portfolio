using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioWebsite.Models  // match your namespace
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }
        [Required, EmailAddress] public string Email { get; set; }
        [Required] public string Subject { get; set; }
        [Required] public string Message { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}