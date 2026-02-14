using Microsoft.EntityFrameworkCore;
using TestService.Model;

namespace TestService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<McqTest> McqTests { get; set; }
        public DbSet<McqQuestion> McqQuestions { get; set; }
        public DbSet<McqOption> McqOptions { get; set; }
        public DbSet<CandidateTestAttempt> CandidateTestAttempts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* ===================== COMPANIES ===================== */
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Google" },
                new Company { Id = 2, Name = "Microsoft" },
                new Company { Id = 3, Name = "Amazon" },
                new Company { Id = 4, Name = "Meta" },
                new Company { Id = 5, Name = "Netflix" },
                new Company { Id = 6, Name = "Apple" },
                new Company { Id = 7, Name = "Tesla" },
                new Company { Id = 8, Name = "IBM" },
                new Company { Id = 9, Name = "Oracle" },
                new Company { Id = 10, Name = "Adobe" },
                new Company { Id = 11, Name = "Salesforce" },
                new Company { Id = 12, Name = "Uber" },
                new Company { Id = 13, Name = "Airbnb" },
                new Company { Id = 14, Name = "Spotify" },
                new Company { Id = 15, Name = "Twitter/X" },
                new Company { Id = 16, Name = "LinkedIn" },
                new Company { Id = 17, Name = "Intel" },
                new Company { Id = 18, Name = "Cisco" },
                new Company { Id = 19, Name = "PayPal" },
                new Company { Id = 20, Name = "Stripe" }
            );

            /* ===================== TESTS ===================== */
            modelBuilder.Entity<McqTest>().HasData(
                new McqTest { Id = 1, CompanyId = 1, Title = "Google MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 2, CompanyId = 2, Title = "Microsoft MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 3, CompanyId = 3, Title = "Amazon MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 4, CompanyId = 4, Title = "Meta MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 5, CompanyId = 5, Title = "Netflix MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 6, CompanyId = 6, Title = "Apple MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 7, CompanyId = 7, Title = "Tesla MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 8, CompanyId = 8, Title = "IBM MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 9, CompanyId = 9, Title = "Oracle MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 10, CompanyId = 10, Title = "Adobe MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 11, CompanyId = 11, Title = "Salesforce MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 12, CompanyId = 12, Title = "Uber MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 13, CompanyId = 13, Title = "Airbnb MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 14, CompanyId = 14, Title = "Spotify MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 15, CompanyId = 15, Title = "Twitter/X MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 16, CompanyId = 16, Title = "LinkedIn MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 17, CompanyId = 17, Title = "Intel MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 18, CompanyId = 18, Title = "Cisco MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 19, CompanyId = 19, Title = "PayPal MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true },
                new McqTest { Id = 20, CompanyId = 20, Title = "Stripe MCQ Test", DurationMinutes = 30, TotalQuestions = 5, IsActive = true }
            );

            /* ===================== QUESTIONS ===================== */
            modelBuilder.Entity<McqQuestion>().HasData(
                // Google (TestId = 1, QuestionId: 1-5)
                new McqQuestion { Id = 1, McqTestId = 1, QuestionText = "What is Big-O notation used for?" },
                new McqQuestion { Id = 2, McqTestId = 1, QuestionText = "Which language is Android primarily written in?" },
                new McqQuestion { Id = 3, McqTestId = 1, QuestionText = "What does JVM stand for?" },
                new McqQuestion { Id = 4, McqTestId = 1, QuestionText = "Which data structure uses FIFO?" },
                new McqQuestion { Id = 5, McqTestId = 1, QuestionText = "What is REST?" },

                // Microsoft (TestId = 2, QuestionId: 6-10)
                new McqQuestion { Id = 6, McqTestId = 2, QuestionText = ".NET is developed by?" },
                new McqQuestion { Id = 7, McqTestId = 2, QuestionText = "What is CLR?" },
                new McqQuestion { Id = 8, McqTestId = 2, QuestionText = "Which language is used with ASP.NET Core?" },
                new McqQuestion { Id = 9, McqTestId = 2, QuestionText = "What does LINQ stand for?" },
                new McqQuestion { Id = 10, McqTestId = 2, QuestionText = "Which DB is from Microsoft?" },

                // Amazon (TestId = 3, QuestionId: 11-15)
                new McqQuestion { Id = 11, McqTestId = 3, QuestionText = "What is AWS?" },
                new McqQuestion { Id = 12, McqTestId = 3, QuestionText = "Which is Amazon's cloud computing platform?" },
                new McqQuestion { Id = 13, McqTestId = 3, QuestionText = "What is DynamoDB?" },
                new McqQuestion { Id = 14, McqTestId = 3, QuestionText = "What does EC2 stand for?" },
                new McqQuestion { Id = 15, McqTestId = 3, QuestionText = "Which AWS service is for object storage?" },

                // Meta (TestId = 4, QuestionId: 16-20)
                new McqQuestion { Id = 16, McqTestId = 4, QuestionText = "React was developed by?" },
                new McqQuestion { Id = 17, McqTestId = 4, QuestionText = "What is GraphQL?" },
                new McqQuestion { Id = 18, McqTestId = 4, QuestionText = "Which database does Facebook use?" },
                new McqQuestion { Id = 19, McqTestId = 4, QuestionText = "What is React Native?" },
                new McqQuestion { Id = 20, McqTestId = 4, QuestionText = "What does FBML stand for?" },

                // Netflix (TestId = 5, QuestionId: 21-25)
                new McqQuestion { Id = 21, McqTestId = 5, QuestionText = "What is Chaos Monkey?" },
                new McqQuestion { Id = 22, McqTestId = 5, QuestionText = "Which cloud provider does Netflix use?" },
                new McqQuestion { Id = 23, McqTestId = 5, QuestionText = "What is Microservices architecture?" },
                new McqQuestion { Id = 24, McqTestId = 5, QuestionText = "Which tool is used for service discovery?" },
                new McqQuestion { Id = 25, McqTestId = 5, QuestionText = "What is Hystrix?" },

                // Apple (TestId = 6, QuestionId: 26-30)
                new McqQuestion { Id = 26, McqTestId = 6, QuestionText = "Which language is used for iOS development?" },
                new McqQuestion { Id = 27, McqTestId = 6, QuestionText = "What is Swift?" },
                new McqQuestion { Id = 28, McqTestId = 6, QuestionText = "What is Xcode?" },
                new McqQuestion { Id = 29, McqTestId = 6, QuestionText = "Which Apple framework is for AR?" },
                new McqQuestion { Id = 30, McqTestId = 6, QuestionText = "What is Core Data?" },

                // Tesla (TestId = 7, QuestionId: 31-35)
                new McqQuestion { Id = 31, McqTestId = 7, QuestionText = "What programming language does Tesla use for Autopilot?" },
                new McqQuestion { Id = 32, McqTestId = 7, QuestionText = "What is Tesla's operating system?" },
                new McqQuestion { Id = 33, McqTestId = 7, QuestionText = "Which AI chip does Tesla develop?" },
                new McqQuestion { Id = 34, McqTestId = 7, QuestionText = "What is Dojo?" },
                new McqQuestion { Id = 35, McqTestId = 7, QuestionText = "Which company's hardware does Tesla use for FSD?" },

                // IBM (TestId = 8, QuestionId: 36-40)
                new McqQuestion { Id = 36, McqTestId = 8, QuestionText = "What is Watson?" },
                new McqQuestion { Id = 37, McqTestId = 8, QuestionText = "Which database is from IBM?" },
                new McqQuestion { Id = 38, McqTestId = 8, QuestionText = "What is IBM Cloud?" },
                new McqQuestion { Id = 39, McqTestId = 8, QuestionText = "What does COBOL stand for?" },
                new McqQuestion { Id = 40, McqTestId = 8, QuestionText = "Which programming language did IBM develop?" },

                // Oracle (TestId = 9, QuestionId: 41-45)
                new McqQuestion { Id = 41, McqTestId = 9, QuestionText = "What is Oracle Database?" },
                new McqQuestion { Id = 42, McqTestId = 9, QuestionText = "Which language is PL/SQL based on?" },
                new McqQuestion { Id = 43, McqTestId = 9, QuestionText = "What is Java's relationship with Oracle?" },
                new McqQuestion { Id = 44, McqTestId = 9, QuestionText = "What is MySQL?" },
                new McqQuestion { Id = 45, McqTestId = 9, QuestionText = "Which tool is Oracle's ERP?" },

                // Adobe (TestId = 10, QuestionId: 46-50)
                new McqQuestion { Id = 46, McqTestId = 10, QuestionText = "What is Photoshop's file format?" },
                new McqQuestion { Id = 47, McqTestId = 10, QuestionText = "Which language is used in Adobe Flash?" },
                new McqQuestion { Id = 48, McqTestId = 10, QuestionText = "What is PDF?" },
                new McqQuestion { Id = 49, McqTestId = 10, QuestionText = "Which Adobe tool is for video editing?" },
                new McqQuestion { Id = 50, McqTestId = 10, QuestionText = "What is Creative Cloud?" },

                // Salesforce (TestId = 11, QuestionId: 51-55)
                new McqQuestion { Id = 51, McqTestId = 11, QuestionText = "What is Apex?" },
                new McqQuestion { Id = 52, McqTestId = 11, QuestionText = "Which language is similar to Apex?" },
                new McqQuestion { Id = 53, McqTestId = 11, QuestionText = "What is Salesforce CRM?" },
                new McqQuestion { Id = 54, McqTestId = 11, QuestionText = "What does SOQL stand for?" },
                new McqQuestion { Id = 55, McqTestId = 11, QuestionText = "Which database does Salesforce use?" },

                // Uber (TestId = 12, QuestionId: 56-60)
                new McqQuestion { Id = 56, McqTestId = 12, QuestionText = "What programming language is Uber's backend in?" },
                new McqQuestion { Id = 57, McqTestId = 12, QuestionText = "Which database does Uber use?" },
                new McqQuestion { Id = 58, McqTestId = 12, QuestionText = "What is Uber's mapping technology?" },
                new McqQuestion { Id = 59, McqTestId = 12, QuestionText = "What is ETA?" },
                new McqQuestion { Id = 60, McqTestId = 12, QuestionText = "Which algorithm is used for ride matching?" },

                // Airbnb (TestId = 13, QuestionId: 61-65)
                new McqQuestion { Id = 61, McqTestId = 13, QuestionText = "Which framework does Airbnb use?" },
                new McqQuestion { Id = 62, McqTestId = 13, QuestionText = "What is Airflow?" },
                new McqQuestion { Id = 63, McqTestId = 13, QuestionText = "Which database does Airbnb use?" },
                new McqQuestion { Id = 64, McqTestId = 13, QuestionText = "What is Airbnb's design system?" },
                new McqQuestion { Id = 65, McqTestId = 13, QuestionText = "Which cloud provider does Airbnb use?" },

                // Spotify (TestId = 14, QuestionId: 66-70)
                new McqQuestion { Id = 66, McqTestId = 14, QuestionText = "What is Spotify's backend language?" },
                new McqQuestion { Id = 67, McqTestId = 14, QuestionText = "Which database does Spotify use?" },
                new McqQuestion { Id = 68, McqTestId = 14, QuestionText = "What is Spotify's recommendation algorithm?" },
                new McqQuestion { Id = 69, McqTestId = 14, QuestionText = "What is Lucio?" },
                new McqQuestion { Id = 70, McqTestId = 14, QuestionText = "Which protocol does Spotify use for streaming?" },

                // Twitter/X (TestId = 15, QuestionId: 71-75)
                new McqQuestion { Id = 71, McqTestId = 15, QuestionText = "Which framework does Twitter use?" },
                new McqQuestion { Id = 72, McqTestId = 15, QuestionText = "What is Finagle?" },
                new McqQuestion { Id = 73, McqTestId = 15, QuestionText = "Which database does Twitter use?" },
                new McqQuestion { Id = 74, McqTestId = 15, QuestionText = "What is Snowflake ID?" },
                new McqQuestion { Id = 75, McqTestId = 15, QuestionText = "Which language is Twitter's backend in?" },

                // LinkedIn (TestId = 16, QuestionId: 76-80)
                new McqQuestion { Id = 76, McqTestId = 16, QuestionText = "Which framework does LinkedIn use?" },
                new McqQuestion { Id = 77, McqTestId = 16, QuestionText = "What is Kafka?" },
                new McqQuestion { Id = 78, McqTestId = 16, QuestionText = "Which database does LinkedIn use?" },
                new McqQuestion { Id = 79, McqTestId = 16, QuestionText = "What is Pinot?" },
                new McqQuestion { Id = 80, McqTestId = 16, QuestionText = "Which language is LinkedIn's backend in?" },

                // Intel (TestId = 17, QuestionId: 81-85)
                new McqQuestion { Id = 81, McqTestId = 17, QuestionText = "What is x86 architecture?" },
                new McqQuestion { Id = 82, McqTestId = 17, QuestionText = "Which instruction set does Intel use?" },
                new McqQuestion { Id = 83, McqTestId = 17, QuestionText = "What is Intel's competitor?" },
                new McqQuestion { Id = 84, McqTestId = 17, QuestionText = "What is SIMD?" },
                new McqQuestion { Id = 85, McqTestId = 17, QuestionText = "Which Intel technology boosts performance?" },

                // Cisco (TestId = 18, QuestionId: 86-90)
                new McqQuestion { Id = 86, McqTestId = 18, QuestionText = "What is Cisco's main business?" },
                new McqQuestion { Id = 87, McqTestId = 18, QuestionText = "What is IOS?" },
                new McqQuestion { Id = 88, McqTestId = 18, QuestionText = "What is a router?" },
                new McqQuestion { Id = 89, McqTestId = 18, QuestionText = "What does VPN stand for?" },
                new McqQuestion { Id = 90, McqTestId = 18, QuestionText = "Which protocol does Cisco develop?" },

                // PayPal (TestId = 19, QuestionId: 91-95)
                new McqQuestion { Id = 91, McqTestId = 19, QuestionText = "Which language does PayPal use?" },
                new McqQuestion { Id = 92, McqTestId = 19, QuestionText = "What is Braintree?" },
                new McqQuestion { Id = 93, McqTestId = 19, QuestionText = "Which database does PayPal use?" },
                new McqQuestion { Id = 94, McqTestId = 19, QuestionText = "What is PayPal's security protocol?" },
                new McqQuestion { Id = 95, McqTestId = 19, QuestionText = "What does PCI DSS stand for?" },

                // Stripe (TestId = 20, QuestionId: 96-100)
                new McqQuestion { Id = 96, McqTestId = 20, QuestionText = "Which language does Stripe use?" },
                new McqQuestion { Id = 97, McqTestId = 20, QuestionText = "What is Stripe's main product?" },
                new McqQuestion { Id = 98, McqTestId = 20, QuestionText = "What is Stripe Connect?" },
                new McqQuestion { Id = 99, McqTestId = 20, QuestionText = "Which database does Stripe use?" },
                new McqQuestion { Id = 100, McqTestId = 20, QuestionText = "What is Stripe Radar?" }
            );

            /* ===================== OPTIONS ===================== */
            modelBuilder.Entity<McqOption>().HasData(
                // Q1 (Google)
                new McqOption { Id = 1, McqQuestionId = 1, OptionText = "Time complexity analysis", IsCorrect = true },
                new McqOption { Id = 2, McqQuestionId = 1, OptionText = "UI design", IsCorrect = false },
                new McqOption { Id = 3, McqQuestionId = 1, OptionText = "Database indexing", IsCorrect = false },
                new McqOption { Id = 4, McqQuestionId = 1, OptionText = "Networking protocol", IsCorrect = false },

                // Q2 (Google)
                new McqOption { Id = 5, McqQuestionId = 2, OptionText = "Java", IsCorrect = true },
                new McqOption { Id = 6, McqQuestionId = 2, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 7, McqQuestionId = 2, OptionText = "Swift", IsCorrect = false },
                new McqOption { Id = 8, McqQuestionId = 2, OptionText = "Go", IsCorrect = false },

                // Q3 (Google)
                new McqOption { Id = 9, McqQuestionId = 3, OptionText = "Java Virtual Machine", IsCorrect = true },
                new McqOption { Id = 10, McqQuestionId = 3, OptionText = "Java Variable Method", IsCorrect = false },
                new McqOption { Id = 11, McqQuestionId = 3, OptionText = "Just Virtual Memory", IsCorrect = false },
                new McqOption { Id = 12, McqQuestionId = 3, OptionText = "None", IsCorrect = false },

                // Q4 (Google)
                new McqOption { Id = 13, McqQuestionId = 4, OptionText = "Queue", IsCorrect = true },
                new McqOption { Id = 14, McqQuestionId = 4, OptionText = "Stack", IsCorrect = false },
                new McqOption { Id = 15, McqQuestionId = 4, OptionText = "Array", IsCorrect = false },
                new McqOption { Id = 16, McqQuestionId = 4, OptionText = "Tree", IsCorrect = false },

                // Q5 (Google)
                new McqOption { Id = 17, McqQuestionId = 5, OptionText = "Representational State Transfer", IsCorrect = true },
                new McqOption { Id = 18, McqQuestionId = 5, OptionText = "Remote Server Technology", IsCorrect = false },
                new McqOption { Id = 19, McqQuestionId = 5, OptionText = "Rapid Execution System", IsCorrect = false },
                new McqOption { Id = 20, McqQuestionId = 5, OptionText = "Random Storage", IsCorrect = false },

                // Q6 (Microsoft)
                new McqOption { Id = 21, McqQuestionId = 6, OptionText = "Microsoft", IsCorrect = true },
                new McqOption { Id = 22, McqQuestionId = 6, OptionText = "Google", IsCorrect = false },
                new McqOption { Id = 23, McqQuestionId = 6, OptionText = "Apple", IsCorrect = false },
                new McqOption { Id = 24, McqQuestionId = 6, OptionText = "Oracle", IsCorrect = false },

                // Q7 (Microsoft)
                new McqOption { Id = 25, McqQuestionId = 7, OptionText = "Common Language Runtime", IsCorrect = true },
                new McqOption { Id = 26, McqQuestionId = 7, OptionText = "C Language Runtime", IsCorrect = false },
                new McqOption { Id = 27, McqQuestionId = 7, OptionText = "Common Library Reference", IsCorrect = false },
                new McqOption { Id = 28, McqQuestionId = 7, OptionText = "Compiler Level Runtime", IsCorrect = false },

                // Q8 (Microsoft)
                new McqOption { Id = 29, McqQuestionId = 8, OptionText = "C#", IsCorrect = true },
                new McqOption { Id = 30, McqQuestionId = 8, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 31, McqQuestionId = 8, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 32, McqQuestionId = 8, OptionText = "Ruby", IsCorrect = false },

                // Q9 (Microsoft)
                new McqOption { Id = 33, McqQuestionId = 9, OptionText = "Language Integrated Query", IsCorrect = true },
                new McqOption { Id = 34, McqQuestionId = 9, OptionText = "Local Internet Query", IsCorrect = false },
                new McqOption { Id = 35, McqQuestionId = 9, OptionText = "Logical Information Queue", IsCorrect = false },
                new McqOption { Id = 36, McqQuestionId = 9, OptionText = "Library Integration", IsCorrect = false },

                // Q10 (Microsoft)
                new McqOption { Id = 37, McqQuestionId = 10, OptionText = "SQL Server", IsCorrect = true },
                new McqOption { Id = 38, McqQuestionId = 10, OptionText = "MySQL", IsCorrect = false },
                new McqOption { Id = 39, McqQuestionId = 10, OptionText = "PostgreSQL", IsCorrect = false },
                new McqOption { Id = 40, McqQuestionId = 10, OptionText = "MongoDB", IsCorrect = false },

                // Q11 (Amazon)
                new McqOption { Id = 41, McqQuestionId = 11, OptionText = "Amazon Web Services", IsCorrect = true },
                new McqOption { Id = 42, McqQuestionId = 11, OptionText = "Advanced Web System", IsCorrect = false },
                new McqOption { Id = 43, McqQuestionId = 11, OptionText = "Amazon Work Station", IsCorrect = false },
                new McqOption { Id = 44, McqQuestionId = 11, OptionText = "Application Web Service", IsCorrect = false },

                // Q12 (Amazon)
                new McqOption { Id = 45, McqQuestionId = 12, OptionText = "AWS", IsCorrect = true },
                new McqOption { Id = 46, McqQuestionId = 12, OptionText = "Azure", IsCorrect = false },
                new McqOption { Id = 47, McqQuestionId = 12, OptionText = "GCP", IsCorrect = false },
                new McqOption { Id = 48, McqQuestionId = 12, OptionText = "IBM Cloud", IsCorrect = false },

                // Q13 (Amazon)
                new McqOption { Id = 49, McqQuestionId = 13, OptionText = "NoSQL database", IsCorrect = true },
                new McqOption { Id = 50, McqQuestionId = 13, OptionText = "SQL database", IsCorrect = false },
                new McqOption { Id = 51, McqQuestionId = 13, OptionText = "Cache system", IsCorrect = false },
                new McqOption { Id = 52, McqQuestionId = 13, OptionText = "File storage", IsCorrect = false },

                // Q14 (Amazon)
                new McqOption { Id = 53, McqQuestionId = 14, OptionText = "Elastic Compute Cloud", IsCorrect = true },
                new McqOption { Id = 54, McqQuestionId = 14, OptionText = "Enterprise Cloud Computing", IsCorrect = false },
                new McqOption { Id = 55, McqQuestionId = 14, OptionText = "Elastic Cache Cloud", IsCorrect = false },
                new McqOption { Id = 56, McqQuestionId = 14, OptionText = "Extended Cloud Compute", IsCorrect = false },

                // Q15 (Amazon)
                new McqOption { Id = 57, McqQuestionId = 15, OptionText = "S3", IsCorrect = true },
                new McqOption { Id = 58, McqQuestionId = 15, OptionText = "EC2", IsCorrect = false },
                new McqOption { Id = 59, McqQuestionId = 15, OptionText = "Lambda", IsCorrect = false },
                new McqOption { Id = 60, McqQuestionId = 15, OptionText = "RDS", IsCorrect = false },

                // Q16 (Meta)
                new McqOption { Id = 61, McqQuestionId = 16, OptionText = "Facebook", IsCorrect = true },
                new McqOption { Id = 62, McqQuestionId = 16, OptionText = "Google", IsCorrect = false },
                new McqOption { Id = 63, McqQuestionId = 16, OptionText = "Microsoft", IsCorrect = false },
                new McqOption { Id = 64, McqQuestionId = 16, OptionText = "Apple", IsCorrect = false },

                // Q17 (Meta)
                new McqOption { Id = 65, McqQuestionId = 17, OptionText = "Query language for APIs", IsCorrect = true },
                new McqOption { Id = 66, McqQuestionId = 17, OptionText = "Graph database", IsCorrect = false },
                new McqOption { Id = 67, McqQuestionId = 17, OptionText = "Charting library", IsCorrect = false },
                new McqOption { Id = 68, McqQuestionId = 17, OptionText = "Graphics library", IsCorrect = false },

                // Q18 (Meta)
                new McqOption { Id = 69, McqQuestionId = 18, OptionText = "MySQL", IsCorrect = true },
                new McqOption { Id = 70, McqQuestionId = 18, OptionText = "MongoDB", IsCorrect = false },
                new McqOption { Id = 71, McqQuestionId = 18, OptionText = "Oracle", IsCorrect = false },
                new McqOption { Id = 72, McqQuestionId = 18, OptionText = "PostgreSQL", IsCorrect = false },

                // Q19 (Meta)
                new McqOption { Id = 73, McqQuestionId = 19, OptionText = "Mobile framework", IsCorrect = true },
                new McqOption { Id = 74, McqQuestionId = 19, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 75, McqQuestionId = 19, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 76, McqQuestionId = 19, OptionText = "Cloud service", IsCorrect = false },

                // Q20 (Meta)
                new McqOption { Id = 77, McqQuestionId = 20, OptionText = "Facebook Markup Language", IsCorrect = true },
                new McqOption { Id = 78, McqQuestionId = 20, OptionText = "Fast Binary ML", IsCorrect = false },
                new McqOption { Id = 79, McqQuestionId = 20, OptionText = "File Based Markup", IsCorrect = false },
                new McqOption { Id = 80, McqQuestionId = 20, OptionText = "Facebook Binary Language", IsCorrect = false },

                // Q21 (Netflix)
                new McqOption { Id = 81, McqQuestionId = 21, OptionText = "Chaos engineering tool", IsCorrect = true },
                new McqOption { Id = 82, McqQuestionId = 21, OptionText = "Game", IsCorrect = false },
                new McqOption { Id = 83, McqQuestionId = 21, OptionText = "Testing framework", IsCorrect = false },
                new McqOption { Id = 84, McqQuestionId = 21, OptionText = "Monitoring tool", IsCorrect = false },

                // Q22 (Netflix)
                new McqOption { Id = 85, McqQuestionId = 22, OptionText = "AWS", IsCorrect = true },
                new McqOption { Id = 86, McqQuestionId = 22, OptionText = "Azure", IsCorrect = false },
                new McqOption { Id = 87, McqQuestionId = 22, OptionText = "GCP", IsCorrect = false },
                new McqOption { Id = 88, McqQuestionId = 22, OptionText = "IBM", IsCorrect = false },

                // Q23 (Netflix)
                new McqOption { Id = 89, McqQuestionId = 23, OptionText = "Architectural style", IsCorrect = true },
                new McqOption { Id = 90, McqQuestionId = 23, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 91, McqQuestionId = 23, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 92, McqQuestionId = 23, OptionText = "Framework", IsCorrect = false },

                // Q24 (Netflix)
                new McqOption { Id = 93, McqQuestionId = 24, OptionText = "Eureka", IsCorrect = true },
                new McqOption { Id = 94, McqQuestionId = 24, OptionText = "Redis", IsCorrect = false },
                new McqOption { Id = 95, McqQuestionId = 24, OptionText = "Kafka", IsCorrect = false },
                new McqOption { Id = 96, McqQuestionId = 24, OptionText = "Zookeeper", IsCorrect = false },

                // Q25 (Netflix)
                new McqOption { Id = 97, McqQuestionId = 25, OptionText = "Latency and fault tolerance library", IsCorrect = true },
                new McqOption { Id = 98, McqQuestionId = 25, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 99, McqQuestionId = 25, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 100, McqQuestionId = 25, OptionText = "Cloud service", IsCorrect = false },

                // Q26 (Apple)
                new McqOption { Id = 101, McqQuestionId = 26, OptionText = "Swift", IsCorrect = true },
                new McqOption { Id = 102, McqQuestionId = 26, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 103, McqQuestionId = 26, OptionText = "Kotlin", IsCorrect = false },
                new McqOption { Id = 104, McqQuestionId = 26, OptionText = "C++", IsCorrect = false },

                // Q27 (Apple)
                new McqOption { Id = 105, McqQuestionId = 27, OptionText = "Programming language", IsCorrect = true },
                new McqOption { Id = 106, McqQuestionId = 27, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 107, McqQuestionId = 27, OptionText = "Framework", IsCorrect = false },
                new McqOption { Id = 108, McqQuestionId = 27, OptionText = "Operating system", IsCorrect = false },

                // Q28 (Apple)
                new McqOption { Id = 109, McqQuestionId = 28, OptionText = "IDE", IsCorrect = true },
                new McqOption { Id = 110, McqQuestionId = 28, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 111, McqQuestionId = 28, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 112, McqQuestionId = 28, OptionText = "Cloud service", IsCorrect = false },

                // Q29 (Apple)
                new McqOption { Id = 113, McqQuestionId = 29, OptionText = "ARKit", IsCorrect = true },
                new McqOption { Id = 114, McqQuestionId = 29, OptionText = "Core ML", IsCorrect = false },
                new McqOption { Id = 115, McqQuestionId = 29, OptionText = "Metal", IsCorrect = false },
                new McqOption { Id = 116, McqQuestionId = 29, OptionText = "SwiftUI", IsCorrect = false },

                // Q30 (Apple)
                new McqOption { Id = 117, McqQuestionId = 30, OptionText = "Persistence framework", IsCorrect = true },
                new McqOption { Id = 118, McqQuestionId = 30, OptionText = "Networking library", IsCorrect = false },
                new McqOption { Id = 119, McqQuestionId = 30, OptionText = "UI framework", IsCorrect = false },
                new McqOption { Id = 120, McqQuestionId = 30, OptionText = "Testing framework", IsCorrect = false },

                // Q31 (Tesla)
                new McqOption { Id = 121, McqQuestionId = 31, OptionText = "Python", IsCorrect = true },
                new McqOption { Id = 122, McqQuestionId = 31, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 123, McqQuestionId = 31, OptionText = "C++", IsCorrect = false },
                new McqOption { Id = 124, McqQuestionId = 31, OptionText = "Rust", IsCorrect = false },

                // Q32 (Tesla)
                new McqOption { Id = 125, McqQuestionId = 32, OptionText = "Linux based", IsCorrect = true },
                new McqOption { Id = 126, McqQuestionId = 32, OptionText = "Windows based", IsCorrect = false },
                new McqOption { Id = 127, McqQuestionId = 32, OptionText = "MacOS based", IsCorrect = false },
                new McqOption { Id = 128, McqQuestionId = 32, OptionText = "Android based", IsCorrect = false },

                // Q33 (Tesla)
                new McqOption { Id = 129, McqQuestionId = 33, OptionText = "D1", IsCorrect = true },
                new McqOption { Id = 130, McqQuestionId = 33, OptionText = "A1", IsCorrect = false },
                new McqOption { Id = 131, McqQuestionId = 33, OptionText = "B1", IsCorrect = false },
                new McqOption { Id = 132, McqQuestionId = 33, OptionText = "C1", IsCorrect = false },

                // Q34 (Tesla)
                new McqOption { Id = 133, McqQuestionId = 34, OptionText = "Training computer", IsCorrect = true },
                new McqOption { Id = 134, McqQuestionId = 34, OptionText = "Car model", IsCorrect = false },
                new McqOption { Id = 135, McqQuestionId = 34, OptionText = "Software update", IsCorrect = false },
                new McqOption { Id = 136, McqQuestionId = 34, OptionText = "Battery type", IsCorrect = false },

                // Q35 (Tesla)
                new McqOption { Id = 137, McqQuestionId = 35, OptionText = "NVIDIA", IsCorrect = true },
                new McqOption { Id = 138, McqQuestionId = 35, OptionText = "Intel", IsCorrect = false },
                new McqOption { Id = 139, McqQuestionId = 35, OptionText = "AMD", IsCorrect = false },
                new McqOption { Id = 140, McqQuestionId = 35, OptionText = "Qualcomm", IsCorrect = false },

                // Q36 (IBM)
                new McqOption { Id = 141, McqQuestionId = 36, OptionText = "AI platform", IsCorrect = true },
                new McqOption { Id = 142, McqQuestionId = 36, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 143, McqQuestionId = 36, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 144, McqQuestionId = 36, OptionText = "Operating system", IsCorrect = false },

                // Q37 (IBM)
                new McqOption { Id = 145, McqQuestionId = 37, OptionText = "DB2", IsCorrect = true },
                new McqOption { Id = 146, McqQuestionId = 37, OptionText = "MySQL", IsCorrect = false },
                new McqOption { Id = 147, McqQuestionId = 37, OptionText = "PostgreSQL", IsCorrect = false },
                new McqOption { Id = 148, McqQuestionId = 37, OptionText = "Oracle", IsCorrect = false },

                // Q38 (IBM)
                new McqOption { Id = 149, McqQuestionId = 38, OptionText = "Cloud platform", IsCorrect = true },
                new McqOption { Id = 150, McqQuestionId = 38, OptionText = "IDE", IsCorrect = false },
                new McqOption { Id = 151, McqQuestionId = 38, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 152, McqQuestionId = 38, OptionText = "Framework", IsCorrect = false },

                // Q39 (IBM)
                new McqOption { Id = 153, McqQuestionId = 39, OptionText = "Common Business Oriented Language", IsCorrect = true },
                new McqOption { Id = 154, McqQuestionId = 39, OptionText = "Computer Business Language", IsCorrect = false },
                new McqOption { Id = 155, McqQuestionId = 39, OptionText = "Common Binary Language", IsCorrect = false },
                new McqOption { Id = 156, McqQuestionId = 39, OptionText = "Corporate Business Language", IsCorrect = false },

                // Q40 (IBM)
                new McqOption { Id = 157, McqQuestionId = 40, OptionText = "FORTRAN", IsCorrect = true },
                new McqOption { Id = 158, McqQuestionId = 40, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 159, McqQuestionId = 40, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 160, McqQuestionId = 40, OptionText = "C++", IsCorrect = false },

                // Q41 (Oracle)
                new McqOption { Id = 161, McqQuestionId = 41, OptionText = "RDBMS", IsCorrect = true },
                new McqOption { Id = 162, McqQuestionId = 41, OptionText = "NoSQL database", IsCorrect = false },
                new McqOption { Id = 163, McqQuestionId = 41, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 164, McqQuestionId = 41, OptionText = "Framework", IsCorrect = false },

                // Q42 (Oracle)
                new McqOption { Id = 165, McqQuestionId = 42, OptionText = "SQL", IsCorrect = true },
                new McqOption { Id = 166, McqQuestionId = 42, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 167, McqQuestionId = 42, OptionText = "C++", IsCorrect = false },
                new McqOption { Id = 168, McqQuestionId = 42, OptionText = "Python", IsCorrect = false },

                // Q43 (Oracle)
                new McqOption { Id = 169, McqQuestionId = 43, OptionText = "Oracle owns Java", IsCorrect = true },
                new McqOption { Id = 170, McqQuestionId = 43, OptionText = "Java owns Oracle", IsCorrect = false },
                new McqOption { Id = 171, McqQuestionId = 43, OptionText = "No relation", IsCorrect = false },
                new McqOption { Id = 172, McqQuestionId = 43, OptionText = "Competitors", IsCorrect = false },

                // Q44 (Oracle)
                new McqOption { Id = 173, McqQuestionId = 44, OptionText = "Open source RDBMS", IsCorrect = true },
                new McqOption { Id = 174, McqQuestionId = 44, OptionText = "NoSQL database", IsCorrect = false },
                new McqOption { Id = 175, McqQuestionId = 44, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 176, McqQuestionId = 44, OptionText = "Cloud service", IsCorrect = false },

                // Q45 (Oracle)
                new McqOption { Id = 177, McqQuestionId = 45, OptionText = "Oracle E-Business Suite", IsCorrect = true },
                new McqOption { Id = 178, McqQuestionId = 45, OptionText = "SAP", IsCorrect = false },
                new McqOption { Id = 179, McqQuestionId = 45, OptionText = "Salesforce", IsCorrect = false },
                new McqOption { Id = 180, McqQuestionId = 45, OptionText = "Workday", IsCorrect = false },

                // Q46 (Adobe)
                new McqOption { Id = 181, McqQuestionId = 46, OptionText = "PSD", IsCorrect = true },
                new McqOption { Id = 182, McqQuestionId = 46, OptionText = "PDF", IsCorrect = false },
                new McqOption { Id = 183, McqQuestionId = 46, OptionText = "JPG", IsCorrect = false },
                new McqOption { Id = 184, McqQuestionId = 46, OptionText = "PNG", IsCorrect = false },

                // Q47 (Adobe)
                new McqOption { Id = 185, McqQuestionId = 47, OptionText = "ActionScript", IsCorrect = true },
                new McqOption { Id = 186, McqQuestionId = 47, OptionText = "JavaScript", IsCorrect = false },
                new McqOption { Id = 187, McqQuestionId = 47, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 188, McqQuestionId = 47, OptionText = "Java", IsCorrect = false },

                // Q48 (Adobe)
                new McqOption { Id = 189, McqQuestionId = 48, OptionText = "Portable Document Format", IsCorrect = true },
                new McqOption { Id = 190, McqQuestionId = 48, OptionText = "Personal Data File", IsCorrect = false },
                new McqOption { Id = 191, McqQuestionId = 48, OptionText = "Print Document Format", IsCorrect = false },
                new McqOption { Id = 192, McqQuestionId = 48, OptionText = "Platform Data File", IsCorrect = false },

                // Q49 (Adobe)
                new McqOption { Id = 193, McqQuestionId = 49, OptionText = "Premiere Pro", IsCorrect = true },
                new McqOption { Id = 194, McqQuestionId = 49, OptionText = "Photoshop", IsCorrect = false },
                new McqOption { Id = 195, McqQuestionId = 49, OptionText = "Illustrator", IsCorrect = false },
                new McqOption { Id = 196, McqQuestionId = 49, OptionText = "After Effects", IsCorrect = false },

                // Q50 (Adobe)
                new McqOption { Id = 197, McqQuestionId = 50, OptionText = "Subscription service", IsCorrect = true },
                new McqOption { Id = 198, McqQuestionId = 50, OptionText = "Cloud storage", IsCorrect = false },
                new McqOption { Id = 199, McqQuestionId = 50, OptionText = "Social media", IsCorrect = false },
                new McqOption { Id = 200, McqQuestionId = 50, OptionText = "E-commerce", IsCorrect = false },

                // Q51 (Salesforce)
                new McqOption { Id = 201, McqQuestionId = 51, OptionText = "Programming language", IsCorrect = true },
                new McqOption { Id = 202, McqQuestionId = 51, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 203, McqQuestionId = 51, OptionText = "Framework", IsCorrect = false },
                new McqOption { Id = 204, McqQuestionId = 51, OptionText = "Cloud service", IsCorrect = false },

                // Q52 (Salesforce)
                new McqOption { Id = 205, McqQuestionId = 52, OptionText = "Java", IsCorrect = true },
                new McqOption { Id = 206, McqQuestionId = 52, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 207, McqQuestionId = 52, OptionText = "C#", IsCorrect = false },
                new McqOption { Id = 208, McqQuestionId = 52, OptionText = "JavaScript", IsCorrect = false },

                // Q53 (Salesforce)
                new McqOption { Id = 209, McqQuestionId = 53, OptionText = "Customer Relationship Management", IsCorrect = true },
                new McqOption { Id = 210, McqQuestionId = 53, OptionText = "Cloud Resource Management", IsCorrect = false },
                new McqOption { Id = 211, McqQuestionId = 53, OptionText = "Content Relationship Manager", IsCorrect = false },
                new McqOption { Id = 212, McqQuestionId = 53, OptionText = "Customer Resource Manager", IsCorrect = false },

                // Q54 (Salesforce)
                new McqOption { Id = 213, McqQuestionId = 54, OptionText = "Salesforce Object Query Language", IsCorrect = true },
                new McqOption { Id = 214, McqQuestionId = 54, OptionText = "Structured Object Query Language", IsCorrect = false },
                new McqOption { Id = 215, McqQuestionId = 54, OptionText = "Salesforce Online Query Language", IsCorrect = false },
                new McqOption { Id = 216, McqQuestionId = 54, OptionText = "Simple Object Query Language", IsCorrect = false },

                // Q55 (Salesforce)
                new McqOption { Id = 217, McqQuestionId = 55, OptionText = "Proprietary database", IsCorrect = true },
                new McqOption { Id = 218, McqQuestionId = 55, OptionText = "MySQL", IsCorrect = false },
                new McqOption { Id = 219, McqQuestionId = 55, OptionText = "Oracle", IsCorrect = false },
                new McqOption { Id = 220, McqQuestionId = 55, OptionText = "PostgreSQL", IsCorrect = false },

                // Q56 (Uber)
                new McqOption { Id = 221, McqQuestionId = 56, OptionText = "Go", IsCorrect = true },
                new McqOption { Id = 222, McqQuestionId = 56, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 223, McqQuestionId = 56, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 224, McqQuestionId = 56, OptionText = "C++", IsCorrect = false },

                // Q57 (Uber)
                new McqOption { Id = 225, McqQuestionId = 57, OptionText = "PostgreSQL", IsCorrect = true },
                new McqOption { Id = 226, McqQuestionId = 57, OptionText = "MySQL", IsCorrect = false },
                new McqOption { Id = 227, McqQuestionId = 57, OptionText = "MongoDB", IsCorrect = false },
                new McqOption { Id = 228, McqQuestionId = 57, OptionText = "Redis", IsCorrect = false },

                // Q58 (Uber)
                new McqOption { Id = 229, McqQuestionId = 58, OptionText = "Google Maps", IsCorrect = true },
                new McqOption { Id = 230, McqQuestionId = 58, OptionText = "Apple Maps", IsCorrect = false },
                new McqOption { Id = 231, McqQuestionId = 58, OptionText = "OpenStreetMap", IsCorrect = false },
                new McqOption { Id = 232, McqQuestionId = 58, OptionText = "HERE Maps", IsCorrect = false },

                // Q59 (Uber)
                new McqOption { Id = 233, McqQuestionId = 59, OptionText = "Estimated Time of Arrival", IsCorrect = true },
                new McqOption { Id = 234, McqQuestionId = 59, OptionText = "Exact Time of Arrival", IsCorrect = false },
                new McqOption { Id = 235, McqQuestionId = 59, OptionText = "Expected Time of Arrival", IsCorrect = false },
                new McqOption { Id = 236, McqQuestionId = 59, OptionText = "Estimated Travel Algorithm", IsCorrect = false },

                // Q60 (Uber)
                new McqOption { Id = 237, McqQuestionId = 60, OptionText = "Greedy algorithm", IsCorrect = true },
                new McqOption { Id = 238, McqQuestionId = 60, OptionText = "Dijkstra", IsCorrect = false },
                new McqOption { Id = 239, McqQuestionId = 60, OptionText = "A*", IsCorrect = false },
                new McqOption { Id = 240, McqQuestionId = 60, OptionText = "BFS", IsCorrect = false },

                // Q61 (Airbnb)
                new McqOption { Id = 241, McqQuestionId = 61, OptionText = "React", IsCorrect = true },
                new McqOption { Id = 242, McqQuestionId = 61, OptionText = "Angular", IsCorrect = false },
                new McqOption { Id = 243, McqQuestionId = 61, OptionText = "Vue", IsCorrect = false },
                new McqOption { Id = 244, McqQuestionId = 61, OptionText = "Ember", IsCorrect = false },

                // Q62 (Airbnb)
                new McqOption { Id = 245, McqQuestionId = 62, OptionText = "Workflow scheduler", IsCorrect = true },
                new McqOption { Id = 246, McqQuestionId = 62, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 247, McqQuestionId = 62, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 248, McqQuestionId = 62, OptionText = "Cloud service", IsCorrect = false },

                // Q63 (Airbnb)
                new McqOption { Id = 249, McqQuestionId = 63, OptionText = "MySQL", IsCorrect = true },
                new McqOption { Id = 250, McqQuestionId = 63, OptionText = "PostgreSQL", IsCorrect = false },
                new McqOption { Id = 251, McqQuestionId = 63, OptionText = "MongoDB", IsCorrect = false },
                new McqOption { Id = 252, McqQuestionId = 63, OptionText = "Redis", IsCorrect = false },

                // Q64 (Airbnb)
                new McqOption { Id = 253, McqQuestionId = 64, OptionText = "DLS", IsCorrect = true },
                new McqOption { Id = 254, McqQuestionId = 64, OptionText = "Bootstrap", IsCorrect = false },
                new McqOption { Id = 255, McqQuestionId = 64, OptionText = "Material UI", IsCorrect = false },
                new McqOption { Id = 256, McqQuestionId = 64, OptionText = "Tailwind", IsCorrect = false },

                // Q65 (Airbnb)
                new McqOption { Id = 257, McqQuestionId = 65, OptionText = "AWS", IsCorrect = true },
                new McqOption { Id = 258, McqQuestionId = 65, OptionText = "Azure", IsCorrect = false },
                new McqOption { Id = 259, McqQuestionId = 65, OptionText = "GCP", IsCorrect = false },
                new McqOption { Id = 260, McqQuestionId = 65, OptionText = "IBM", IsCorrect = false },

                // Q66 (Spotify)
                new McqOption { Id = 261, McqQuestionId = 66, OptionText = "Python", IsCorrect = true },
                new McqOption { Id = 262, McqQuestionId = 66, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 263, McqQuestionId = 66, OptionText = "Go", IsCorrect = false },
                new McqOption { Id = 264, McqQuestionId = 66, OptionText = "C++", IsCorrect = false },

                // Q67 (Spotify)
                new McqOption { Id = 265, McqQuestionId = 67, OptionText = "Cassandra", IsCorrect = true },
                new McqOption { Id = 266, McqQuestionId = 67, OptionText = "MySQL", IsCorrect = false },
                new McqOption { Id = 267, McqQuestionId = 67, OptionText = "PostgreSQL", IsCorrect = false },
                new McqOption { Id = 268, McqQuestionId = 67, OptionText = "MongoDB", IsCorrect = false },

                // Q68 (Spotify)
                new McqOption { Id = 269, McqQuestionId = 68, OptionText = "Collaborative filtering", IsCorrect = true },
                new McqOption { Id = 270, McqQuestionId = 68, OptionText = "Decision trees", IsCorrect = false },
                new McqOption { Id = 271, McqQuestionId = 68, OptionText = "Neural networks", IsCorrect = false },
                new McqOption { Id = 272, McqQuestionId = 68, OptionText = "Linear regression", IsCorrect = false },

                // Q69 (Spotify)
                new McqOption { Id = 273, McqQuestionId = 69, OptionText = "Audio codec", IsCorrect = true },
                new McqOption { Id = 274, McqQuestionId = 69, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 275, McqQuestionId = 69, OptionText = "Framework", IsCorrect = false },
                new McqOption { Id = 276, McqQuestionId = 69, OptionText = "Programming language", IsCorrect = false },

                // Q70 (Spotify)
                new McqOption { Id = 277, McqQuestionId = 70, OptionText = "HTTP", IsCorrect = true },
                new McqOption { Id = 278, McqQuestionId = 70, OptionText = "FTP", IsCorrect = false },
                new McqOption { Id = 279, McqQuestionId = 70, OptionText = "RTMP", IsCorrect = false },
                new McqOption { Id = 280, McqQuestionId = 70, OptionText = "UDP", IsCorrect = false },

                // Q71 (Twitter/X)
                new McqOption { Id = 281, McqQuestionId = 71, OptionText = "Ruby on Rails", IsCorrect = true },
                new McqOption { Id = 282, McqQuestionId = 71, OptionText = "Django", IsCorrect = false },
                new McqOption { Id = 283, McqQuestionId = 71, OptionText = "Spring", IsCorrect = false },
                new McqOption { Id = 284, McqQuestionId = 71, OptionText = "Laravel", IsCorrect = false },

                // Q72 (Twitter/X)
                new McqOption { Id = 285, McqQuestionId = 72, OptionText = "RPC framework", IsCorrect = true },
                new McqOption { Id = 286, McqQuestionId = 72, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 287, McqQuestionId = 72, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 288, McqQuestionId = 72, OptionText = "Cloud service", IsCorrect = false },

                // Q73 (Twitter/X)
                new McqOption { Id = 289, McqQuestionId = 73, OptionText = "MySQL", IsCorrect = true },
                new McqOption { Id = 290, McqQuestionId = 73, OptionText = "PostgreSQL", IsCorrect = false },
                new McqOption { Id = 291, McqQuestionId = 73, OptionText = "MongoDB", IsCorrect = false },
                new McqOption { Id = 292, McqQuestionId = 73, OptionText = "Cassandra", IsCorrect = false },

                // Q74 (Twitter/X)
                new McqOption { Id = 293, McqQuestionId = 74, OptionText = "Distributed ID generator", IsCorrect = true },
                new McqOption { Id = 294, McqQuestionId = 74, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 295, McqQuestionId = 74, OptionText = "Framework", IsCorrect = false },
                new McqOption { Id = 296, McqQuestionId = 74, OptionText = "Cloud service", IsCorrect = false },

                // Q75 (Twitter/X)
                new McqOption { Id = 297, McqQuestionId = 75, OptionText = "Scala", IsCorrect = true },
                new McqOption { Id = 298, McqQuestionId = 75, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 299, McqQuestionId = 75, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 300, McqQuestionId = 75, OptionText = "Ruby", IsCorrect = false },

                // Q76 (LinkedIn)
                new McqOption { Id = 301, McqQuestionId = 76, OptionText = "Play Framework", IsCorrect = true },
                new McqOption { Id = 302, McqQuestionId = 76, OptionText = "Spring", IsCorrect = false },
                new McqOption { Id = 303, McqQuestionId = 76, OptionText = "Django", IsCorrect = false },
                new McqOption { Id = 304, McqQuestionId = 76, OptionText = "Express", IsCorrect = false },

                // Q77 (LinkedIn)
                new McqOption { Id = 305, McqQuestionId = 77, OptionText = "Distributed streaming platform", IsCorrect = true },
                new McqOption { Id = 306, McqQuestionId = 77, OptionText = "Database", IsCorrect = false },
                new McqOption { Id = 307, McqQuestionId = 77, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 308, McqQuestionId = 77, OptionText = "Cloud service", IsCorrect = false },

                // Q78 (LinkedIn)
                new McqOption { Id = 309, McqQuestionId = 78, OptionText = "Espresso", IsCorrect = true },
                new McqOption { Id = 310, McqQuestionId = 78, OptionText = "MySQL", IsCorrect = false },
                new McqOption { Id = 311, McqQuestionId = 78, OptionText = "PostgreSQL", IsCorrect = false },
                new McqOption { Id = 312, McqQuestionId = 78, OptionText = "Oracle", IsCorrect = false },

                // Q79 (LinkedIn)
                new McqOption { Id = 313, McqQuestionId = 79, OptionText = "Real-time analytics database", IsCorrect = true },
                new McqOption { Id = 314, McqQuestionId = 79, OptionText = "Programming language", IsCorrect = false },
                new McqOption { Id = 315, McqQuestionId = 79, OptionText = "Framework", IsCorrect = false },
                new McqOption { Id = 316, McqQuestionId = 79, OptionText = "Cloud service", IsCorrect = false },

                // Q80 (LinkedIn)
                new McqOption { Id = 317, McqQuestionId = 80, OptionText = "Java", IsCorrect = true },
                new McqOption { Id = 318, McqQuestionId = 80, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 319, McqQuestionId = 80, OptionText = "Go", IsCorrect = false },
                new McqOption { Id = 320, McqQuestionId = 80, OptionText = "C++", IsCorrect = false },

                // Q81 (Intel)
                new McqOption { Id = 321, McqQuestionId = 81, OptionText = "CPU architecture", IsCorrect = true },
                new McqOption { Id = 322, McqQuestionId = 81, OptionText = "GPU architecture", IsCorrect = false },
                new McqOption { Id = 323, McqQuestionId = 81, OptionText = "Networking protocol", IsCorrect = false },
                new McqOption { Id = 324, McqQuestionId = 81, OptionText = "Programming language", IsCorrect = false },

                // Q82 (Intel)
                new McqOption { Id = 325, McqQuestionId = 82, OptionText = "x86", IsCorrect = true },
                new McqOption { Id = 326, McqQuestionId = 82, OptionText = "ARM", IsCorrect = false },
                new McqOption { Id = 327, McqQuestionId = 82, OptionText = "RISC-V", IsCorrect = false },
                new McqOption { Id = 328, McqQuestionId = 82, OptionText = "MIPS", IsCorrect = false },

                // Q83 (Intel)
                new McqOption { Id = 329, McqQuestionId = 83, OptionText = "AMD", IsCorrect = true },
                new McqOption { Id = 330, McqQuestionId = 83, OptionText = "NVIDIA", IsCorrect = false },
                new McqOption { Id = 331, McqQuestionId = 83, OptionText = "Qualcomm", IsCorrect = false },
                new McqOption { Id = 332, McqQuestionId = 83, OptionText = "Apple", IsCorrect = false },

                // Q84 (Intel)
                new McqOption { Id = 333, McqQuestionId = 84, OptionText = "Single Instruction Multiple Data", IsCorrect = true },
                new McqOption { Id = 334, McqQuestionId = 84, OptionText = "Single Instruction Single Data", IsCorrect = false },
                new McqOption { Id = 335, McqQuestionId = 84, OptionText = "Multiple Instruction Single Data", IsCorrect = false },
                new McqOption { Id = 336, McqQuestionId = 84, OptionText = "Multiple Instruction Multiple Data", IsCorrect = false },

                // Q85 (Intel)
                new McqOption { Id = 337, McqQuestionId = 85, OptionText = "Hyper-Threading", IsCorrect = true },
                new McqOption { Id = 338, McqQuestionId = 85, OptionText = "Turbo Boost", IsCorrect = false },
                new McqOption { Id = 339, McqQuestionId = 85, OptionText = "Virtualization", IsCorrect = false },
                new McqOption { Id = 340, McqQuestionId = 85, OptionText = "Overclocking", IsCorrect = false },

                // Q86 (Cisco)
                new McqOption { Id = 341, McqQuestionId = 86, OptionText = "Networking hardware", IsCorrect = true },
                new McqOption { Id = 342, McqQuestionId = 86, OptionText = "Software development", IsCorrect = false },
                new McqOption { Id = 343, McqQuestionId = 86, OptionText = "Cloud services", IsCorrect = false },
                new McqOption { Id = 344, McqQuestionId = 86, OptionText = "Consumer electronics", IsCorrect = false },

                // Q87 (Cisco)
                new McqOption { Id = 345, McqQuestionId = 87, OptionText = "Internetwork Operating System", IsCorrect = true },
                new McqOption { Id = 346, McqQuestionId = 87, OptionText = "International Operating System", IsCorrect = false },
                new McqOption { Id = 347, McqQuestionId = 87, OptionText = "Internet Operating System", IsCorrect = false },
                new McqOption { Id = 348, McqQuestionId = 87, OptionText = "Integrated Operating System", IsCorrect = false },

                // Q88 (Cisco)
                new McqOption { Id = 349, McqQuestionId = 88, OptionText = "Networking device", IsCorrect = true },
                new McqOption { Id = 350, McqQuestionId = 88, OptionText = "Storage device", IsCorrect = false },
                new McqOption { Id = 351, McqQuestionId = 88, OptionText = "Security device", IsCorrect = false },
                new McqOption { Id = 352, McqQuestionId = 88, OptionText = "Compute device", IsCorrect = false },

                // Q89 (Cisco)
                new McqOption { Id = 353, McqQuestionId = 89, OptionText = "Virtual Private Network", IsCorrect = true },
                new McqOption { Id = 354, McqQuestionId = 89, OptionText = "Virtual Public Network", IsCorrect = false },
                new McqOption { Id = 355, McqQuestionId = 89, OptionText = "Verified Private Network", IsCorrect = false },
                new McqOption { Id = 356, McqQuestionId = 89, OptionText = "Virtual Protocol Network", IsCorrect = false },

                // Q90 (Cisco)
                new McqOption { Id = 357, McqQuestionId = 90, OptionText = "CCNP", IsCorrect = true },
                new McqOption { Id = 358, McqQuestionId = 90, OptionText = "TCP/IP", IsCorrect = false },
                new McqOption { Id = 359, McqQuestionId = 90, OptionText = "HTTP", IsCorrect = false },
                new McqOption { Id = 360, McqQuestionId = 90, OptionText = "FTP", IsCorrect = false },

                // Q91 (PayPal)
                new McqOption { Id = 361, McqQuestionId = 91, OptionText = "Java", IsCorrect = true },
                new McqOption { Id = 362, McqQuestionId = 91, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 363, McqQuestionId = 91, OptionText = "C++", IsCorrect = false },
                new McqOption { Id = 364, McqQuestionId = 91, OptionText = "Ruby", IsCorrect = false },

                // Q92 (PayPal)
                new McqOption { Id = 365, McqQuestionId = 92, OptionText = "Payment gateway", IsCorrect = true },
                new McqOption { Id = 366, McqQuestionId = 92, OptionText = "Bank", IsCorrect = false },
                new McqOption { Id = 367, McqQuestionId = 92, OptionText = "Cryptocurrency", IsCorrect = false },
                new McqOption { Id = 368, McqQuestionId = 92, OptionText = "Trading platform", IsCorrect = false },

                // Q93 (PayPal)
                new McqOption { Id = 369, McqQuestionId = 93, OptionText = "MySQL", IsCorrect = true },
                new McqOption { Id = 370, McqQuestionId = 93, OptionText = "PostgreSQL", IsCorrect = false },
                new McqOption { Id = 371, McqQuestionId = 93, OptionText = "Oracle", IsCorrect = false },
                new McqOption { Id = 372, McqQuestionId = 93, OptionText = "MongoDB", IsCorrect = false },

                // Q94 (PayPal)
                new McqOption { Id = 373, McqQuestionId = 94, OptionText = "Two-factor authentication", IsCorrect = true },
                new McqOption { Id = 374, McqQuestionId = 94, OptionText = "SSL", IsCorrect = false },
                new McqOption { Id = 375, McqQuestionId = 94, OptionText = "Firewall", IsCorrect = false },
                new McqOption { Id = 376, McqQuestionId = 94, OptionText = "VPN", IsCorrect = false },

                // Q95 (PayPal)
                new McqOption { Id = 377, McqQuestionId = 95, OptionText = "Payment Card Industry Data Security Standard", IsCorrect = true },
                new McqOption { Id = 378, McqQuestionId = 95, OptionText = "Payment Card International Data Standard", IsCorrect = false },
                new McqOption { Id = 379, McqQuestionId = 95, OptionText = "Personal Card Information Data Security", IsCorrect = false },
                new McqOption { Id = 380, McqQuestionId = 95, OptionText = "Payment Card Information Data Security", IsCorrect = false },

                // Q96 (Stripe)
                new McqOption { Id = 381, McqQuestionId = 96, OptionText = "Ruby", IsCorrect = true },
                new McqOption { Id = 382, McqQuestionId = 96, OptionText = "Java", IsCorrect = false },
                new McqOption { Id = 383, McqQuestionId = 96, OptionText = "Python", IsCorrect = false },
                new McqOption { Id = 384, McqQuestionId = 96, OptionText = "Go", IsCorrect = false },

                // Q97 (Stripe)
                new McqOption { Id = 385, McqQuestionId = 97, OptionText = "Payment processing", IsCorrect = true },
                new McqOption { Id = 386, McqQuestionId = 97, OptionText = "Banking", IsCorrect = false },
                new McqOption { Id = 387, McqQuestionId = 97, OptionText = "Insurance", IsCorrect = false },
                new McqOption { Id = 388, McqQuestionId = 97, OptionText = "Trading", IsCorrect = false },

                // Q98 (Stripe)
                new McqOption { Id = 389, McqQuestionId = 98, OptionText = "Platform for marketplaces", IsCorrect = true },
                new McqOption { Id = 390, McqQuestionId = 98, OptionText = "Banking service", IsCorrect = false },
                new McqOption { Id = 391, McqQuestionId = 98, OptionText = "Investment platform", IsCorrect = false },
                new McqOption { Id = 392, McqQuestionId = 98, OptionText = "Cryptocurrency wallet", IsCorrect = false },

                // Q99 (Stripe)
                new McqOption { Id = 393, McqQuestionId = 99, OptionText = "PostgreSQL", IsCorrect = true },
                new McqOption { Id = 394, McqQuestionId = 99, OptionText = "MySQL", IsCorrect = false },
                new McqOption { Id = 395, McqQuestionId = 99, OptionText = "MongoDB", IsCorrect = false },
                new McqOption { Id = 396, McqQuestionId = 99, OptionText = "Redis", IsCorrect = false },

                // Q100 (Stripe)
                new McqOption { Id = 397, McqQuestionId = 100, OptionText = "Fraud prevention", IsCorrect = true },
                new McqOption { Id = 398, McqQuestionId = 100, OptionText = "Payment gateway", IsCorrect = false },
                new McqOption { Id = 399, McqQuestionId = 100, OptionText = "Banking service", IsCorrect = false },
                new McqOption { Id = 400, McqQuestionId = 100, OptionText = "Analytics tool", IsCorrect = false }
            );
        }
    }
}