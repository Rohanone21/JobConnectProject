using CompanyReviewsService.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CompanyReviewsService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyReview> CompanyReviews { get; set; }
        public DbSet<CompanyRatingSummary> CompanyRatingSummaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* ======================
             * PRIMARY KEYS
             * ====================== */
            modelBuilder.Entity<Company>().HasKey(c => c.Id);
            modelBuilder.Entity<CompanyReview>().HasKey(r => r.Id);
            modelBuilder.Entity<CompanyRatingSummary>().HasKey(s => s.Id);

            /* ======================
             * RELATIONSHIPS
             * ====================== */

            // Company -> Reviews (One to Many)
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Reviews)
                .WithOne(r => r.Company)
                .HasForeignKey(r => r.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            // Company -> RatingSummary (One to One)
            modelBuilder.Entity<Company>()
                .HasOne(c => c.RatingSummary)
                .WithOne(s => s.Company)
                .HasForeignKey<CompanyRatingSummary>(s => s.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            /* ======================
             * COMPANY SEED DATA (15)
             * ====================== */
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "TCS", Industry = "IT Services", CompanySize = "500,000+", Headquarters = "Mumbai, India", FoundedYear = 1968, Website = "https://www.tcs.com", About = "Global IT services", LogoUrl = "https://logo.clearbit.com/tcs.com" },
                new Company { Id = 2, Name = "Infosys", Industry = "IT Services", CompanySize = "300,000+", Headquarters = "Bengaluru, India", FoundedYear = 1981, Website = "https://www.infosys.com", About = "Consulting & IT services", LogoUrl = "https://logo.clearbit.com/infosys.com" },
                new Company { Id = 3, Name = "Wipro", Industry = "IT Services", CompanySize = "250,000+", Headquarters = "Bengaluru, India", FoundedYear = 1945, Website = "https://www.wipro.com", About = "IT & consulting", LogoUrl = "https://logo.clearbit.com/wipro.com" },
                new Company { Id = 4, Name = "HCL Technologies", Industry = "IT Services", CompanySize = "220,000+", Headquarters = "Noida, India", FoundedYear = 1976, Website = "https://www.hcltech.com", About = "Global IT enterprise", LogoUrl = "https://logo.clearbit.com/hcltech.com" },
                new Company { Id = 5, Name = "Tech Mahindra", Industry = "IT Services", CompanySize = "150,000+", Headquarters = "Pune, India", FoundedYear = 1986, Website = "https://www.techmahindra.com", About = "Digital transformation", LogoUrl = "https://logo.clearbit.com/techmahindra.com" },
                new Company { Id = 6, Name = "Accenture", Industry = "Consulting", CompanySize = "700,000+", Headquarters = "Dublin, Ireland", FoundedYear = 1989, Website = "https://www.accenture.com", About = "Professional services", LogoUrl = "https://logo.clearbit.com/accenture.com" },
                new Company { Id = 7, Name = "Capgemini", Industry = "Consulting", CompanySize = "350,000+", Headquarters = "Paris, France", FoundedYear = 1967, Website = "https://www.capgemini.com", About = "IT consulting", LogoUrl = "https://logo.clearbit.com/capgemini.com" },
                new Company { Id = 8, Name = "Cognizant", Industry = "IT Services", CompanySize = "300,000+", Headquarters = "New Jersey, USA", FoundedYear = 1994, Website = "https://www.cognizant.com", About = "Digital transformation", LogoUrl = "https://logo.clearbit.com/cognizant.com" },
                new Company { Id = 9, Name = "IBM", Industry = "Technology", CompanySize = "280,000+", Headquarters = "New York, USA", FoundedYear = 1911, Website = "https://www.ibm.com", About = "Enterprise tech solutions", LogoUrl = "https://logo.clearbit.com/ibm.com" },
                new Company { Id = 10, Name = "Microsoft", Industry = "Software", CompanySize = "220,000+", Headquarters = "Redmond, USA", FoundedYear = 1975, Website = "https://www.microsoft.com", About = "Cloud & AI products", LogoUrl = "https://logo.clearbit.com/microsoft.com" },
                new Company { Id = 11, Name = "Google", Industry = "Technology", CompanySize = "190,000+", Headquarters = "California, USA", FoundedYear = 1998, Website = "https://www.google.com", About = "Search & AI", LogoUrl = "https://logo.clearbit.com/google.com" },
                new Company { Id = 12, Name = "Amazon", Industry = "Cloud & E-commerce", CompanySize = "1,500,000+", Headquarters = "Seattle, USA", FoundedYear = 1994, Website = "https://www.amazon.com", About = "AWS & retail", LogoUrl = "https://logo.clearbit.com/amazon.com" },
                new Company { Id = 13, Name = "Oracle", Industry = "Enterprise Software", CompanySize = "160,000+", Headquarters = "Texas, USA", FoundedYear = 1977, Website = "https://www.oracle.com", About = "Database solutions", LogoUrl = "https://logo.clearbit.com/oracle.com" },
                new Company { Id = 14, Name = "SAP", Industry = "Enterprise Software", CompanySize = "110,000+", Headquarters = "Germany", FoundedYear = 1972, Website = "https://www.sap.com", About = "ERP solutions", LogoUrl = "https://logo.clearbit.com/sap.com" },
                new Company { Id = 15, Name = "Zoho", Industry = "Software", CompanySize = "12,000+", Headquarters = "Chennai, India", FoundedYear = 1996, Website = "https://www.zoho.com", About = "Business software", LogoUrl = "https://logo.clearbit.com/zoho.com" }
            );

            /* ======================
             * RATING SUMMARY SEED
             * ====================== */
            for (int i = 1; i <= 15; i++)
            {
                modelBuilder.Entity<CompanyRatingSummary>().HasData(
                    new CompanyRatingSummary
                    {
                        Id = i,
                        CompanyId = i,
                        AvgOverallRating = 3.5,
                        AvgWorkLifeBalance = 3.6,
                        AvgCompensation = 3.7,
                        AvgJobSecurity = 4.0,
                        AvgCareerGrowth = 3.8,
                        AvgManagement = 3.5,
                        AvgCulture = 3.9,
                        TotalReviews = i * 100,
                        LastUpdated = DateTime.UtcNow
                    }
                );
            }

            /* ======================
             * COMPANY REVIEWS SEED
             * ====================== */
            modelBuilder.Entity<CompanyReview>().HasData(
                new CompanyReview
                {
                    Id = 1,
                    CompanyId = 1,
                    JobTitle = "Software Engineer",
                    EmploymentStatus = "Current Employee",
                    Location = "Pune",
                    WorkLifeBalance = 3,
                    CompensationBenefits = 3,
                    JobSecurity = 5,
                    CareerGrowth = 3,
                    Management = 4,
                    Culture = 4,
                    OverallRating = 4.0,
                    Pros = "Job security",
                    Cons = "Slow growth",
                    AdviceToManagement = "Improve hikes",
                    IsAnonymous = true,
                    IsApproved = true,
                    CreatedAt = DateTime.UtcNow.AddDays(-30)
                },
                new CompanyReview
                {
                    Id = 2,
                    CompanyId = 10,
                    JobTitle = "Senior Developer",
                    EmploymentStatus = "Current Employee",
                    Location = "Hyderabad",
                    WorkLifeBalance = 2,
                    CompensationBenefits = 5,
                    JobSecurity = 5,
                    CareerGrowth = 5,
                    Management = 4,
                    Culture = 5,
                    OverallRating = 4.8,
                    Pros = "Pay & culture",
                    Cons = "High workload",
                    AdviceToManagement = "Maintain balance",
                    IsAnonymous = false,
                    IsApproved = true,
                    CreatedAt = DateTime.UtcNow.AddDays(-10)
                }
            );
        }
    }
}
