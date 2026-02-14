namespace CompanyReviewsService.DTO_S
{
    public class AddCompanyDto
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }

        public string Industry { get; set; }

        public string CompanySize { get; set; }
        public string Headquarters { get; set; }
        public  int FoundedYear     { get; set; }

        public string Website { get; set; }

        public string About { get; set; }
    }
}
