using AdminService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AdminService.Data
{
    public class AdminJobDbContext:DbContext
    {
        public AdminJobDbContext(DbContextOptions<AdminJobDbContext> options):base(options)
        {
            
         }
        public DbSet<Job>Jobs2 {  get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.Job)
                .WithMany(j => j.JobApplications)
                .HasForeignKey(ja => ja.JobId);

            // ✅ FIX salary warning
            modelBuilder.Entity<Job>()
                .Property(j => j.Salary)
                .HasPrecision(18, 2);
        }


    }
}
