using System.ComponentModel.DataAnnotations;

namespace TestService.Model
{
    public class McqQuestion
    {
        public int Id { get; set; }

        [Required]
        public int McqTestId { get; set; }

        [Required]
        public string QuestionText { get; set; }

        public McqTest McqTest { get; set; }

        public ICollection<McqOption>Options { get; set; }

    }
}
