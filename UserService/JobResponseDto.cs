using System.ComponentModel.DataAnnotations;

namespace UserService
{
    public class JobResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CompanyLogo { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;

        public string Location {  get; set; } 
        public  decimal Salary { get; set; }


        [Required]

        public int JobId { get; set; }

        [Required]
        public string ApplicationName { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;


        [Required]
        public string ResumeUrl { get; set; } = string.Empty;

        public DateTime AppliedOn { get; set; } = DateTime.UtcNow;

        public bool IsShortlisted { get; set; } = false;

        [Required]
        [StringLength(10)]
        public string MobileNo { get; set; } = string.Empty;

        [Required, StringLength(500)]
        public string Address { get; set; } = String.Empty;

        [Required]
        public string HighestQualification { get; set; } = String.Empty;


        [Required]
        public string PhotographUrl { get; set; } = String.Empty;

        [Required]
        [StringLength(300)]
        public string Skills { get; set; } = String.Empty;

        [Required]
        public string? LinkedInProfile { get; set; }

        [Required]
        public string? GitHubProfile { get; set; }

        [Required]
        public string? PortfolioUrl { get; set; }

        public bool IsWillingToRelocate { get; set; }
        public bool IsApplied { get; set; } = false;
    }
}
