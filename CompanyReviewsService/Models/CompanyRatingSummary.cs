using System.ComponentModel.DataAnnotations;

namespace CompanyReviewsService.Models
{
    public class CompanyRatingSummary
    {
        [Key]
        public int Id { get; set; } 
        public int CompanyId { get; set; }

        public double AvgOverallRating { get; set; }
        public double AvgWorkLifeBalance { get; set; }
        public double AvgCompensation { get; set; }
        public double AvgJobSecurity { get; set; }
        public double AvgCareerGrowth { get; set; }

        public double AvgManagement { get; set; }
        public double AvgCulture { get; set; }

        public int TotalReviews { get; set; }

        public DateTime LastUpdated { get; set; }=DateTime.UtcNow;

        public Company Company { get; set; }


    }
}
