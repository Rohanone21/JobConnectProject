using System.ComponentModel.DataAnnotations;

namespace TestService.Model
{
    public class McqTest
    {
       public int Id { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required,StringLength(100)]

        public string Title { get; set; }

        public int TotalQuestions { get; set; }

        public int DurationMinutes { get; set; }

        public bool IsActive { get; set; }

        public Company Company { get; set; }

        public ICollection<McqQuestion>Questions { get; set; }


    }
}
