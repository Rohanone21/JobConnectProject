namespace CompanyReviewsService.DTO_S
{
    public class CompanyReviewResponseDto
    {
        public string JobTitle { get; set; }

        public string EmploymentStatus { get; set; }

        public string Location { get; set; }

        public double OverallRating { get; set; }

        public string Pros {  get; set; }

        public string Cons { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
