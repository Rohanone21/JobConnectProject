using System.ComponentModel.DataAnnotations;

namespace AdminService.DTOs
{
    public class ApplyJobDto
    {
        [Required]
        public int JobId { get; set; }

        [Required]
        [StringLength(100)]
        public string ApplicationName { get; set; } = String.Empty;

        [Required]
        [StringLength (10)]
        public string MobileNo { get; set; }=string.Empty;

        [Required,StringLength(500)]
        public string Address {  get; set; } = String.Empty;
        


        [Required]
        [EmailAddress]
        public string Email { get; set; }= String.Empty;

        [Required]
        public string HighestQualification {  get; set; } = String.Empty;

        [Required]
        public string ResumeUrl { get; set; } = String.Empty;

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

        public DateTime AppliedOn { get; set; } = DateTime.UtcNow;

        public bool IsShortlisted { get; set; } = false;

        public bool IsApplied { get; set; } = false;


    }
}
