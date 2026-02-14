using System.ComponentModel.DataAnnotations;

namespace TestService.Model
{
    public class McqOption
    {
        public int Id { get; set; }

        [Required]
        public int McqQuestionId { get; set; }  

        [Required]
        public string OptionText { get; set; }

        public bool IsCorrect { get; set; }

        public McqQuestion McqQuestion { get; set; }
    }
}
