using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace AdminService.DTOs
{
    public class CreateJobDto
    {
   
        public string? Title { get; set; }

         
        public string? Company {  get; set; }

        public string? CompanyLogo { get; set; } 

        public string? Description { get; set; }


        public string? Location { get; set; }

   

        [Range(0, double.MaxValue)]

        public decimal? Salary { get; set; }


    }
}
