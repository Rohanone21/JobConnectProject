using System.ComponentModel.DataAnnotations;

namespace CompanyReviewsService.Models
{
    public class Company
    {

        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string Industry { get; set; }    
        public string CompanySize { get; set; }

        public string Headquarters { get; set; }

        public int FoundedYear { get; set; }

        public string Website {  get; set; }

        public string About { get; set; }

        public DateTime CreatedAt { get; set; }=DateTime.UtcNow;

        public ICollection<CompanyReview> Reviews { get; set; }
        public  CompanyRatingSummary RatingSummary { get; set; }

    }
}
