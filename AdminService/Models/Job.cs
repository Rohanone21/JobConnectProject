using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminService.Models
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }=string.Empty;

        [Required]
        public string CompanyLogo {  get; set; }=string.Empty;

        [Required]
        [StringLength(100)]
        public string Company {  get; set; }=string.Empty;

        [Required]

        public string Location {  get; set; }=string.Empty;

        [Required]
        public string Description { get; set; }= string.Empty;

        [Range(0,double.MaxValue)]
        public decimal Salary {  get; set; }=decimal.MaxValue;
        
        public DateTime postedDate { get; set; }=DateTime.UtcNow;

        public ICollection<JobApplication> JobApplications { get; set; }=new List<JobApplication>();


    }
}
