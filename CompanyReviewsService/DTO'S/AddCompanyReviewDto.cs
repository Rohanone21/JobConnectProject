namespace CompanyReviewsService.DTO_S
{
    public class AddCompanyReviewDto
    {
        public int CompanyId { get; set; }

        public string JobTitle { get; set; }

        public string EmploymentStatus { get; set; }

        public string Location { get; set; }

        public int WorkLifeBalance { get; set; }
        public int CompensationBenefits { get; set; }
        public int JobSecurity { get; set; }

        public int CareerGrowth { get; set; }

        public int Management { get; set; }

        public int Culture { get; set; }

        public string Pros { get; set; }

        public string Cons { get; set; }

        public string AdviceToManagement { get; set; }

        public bool IsAnonymous { get; set; }

    }
}
