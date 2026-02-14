using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyReviewsService.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanySize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Headquarters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundedYear = table.Column<int>(type: "int", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRatingSummaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    AvgOverallRating = table.Column<double>(type: "float", nullable: false),
                    AvgWorkLifeBalance = table.Column<double>(type: "float", nullable: false),
                    AvgCompensation = table.Column<double>(type: "float", nullable: false),
                    AvgJobSecurity = table.Column<double>(type: "float", nullable: false),
                    AvgCareerGrowth = table.Column<double>(type: "float", nullable: false),
                    AvgManagement = table.Column<double>(type: "float", nullable: false),
                    AvgCulture = table.Column<double>(type: "float", nullable: false),
                    TotalReviews = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRatingSummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyRatingSummaries_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkLifeBalance = table.Column<int>(type: "int", nullable: false),
                    CompensationBenefits = table.Column<int>(type: "int", nullable: false),
                    JobSecurity = table.Column<int>(type: "int", nullable: false),
                    CareerGrowth = table.Column<int>(type: "int", nullable: false),
                    Management = table.Column<int>(type: "int", nullable: false),
                    Culture = table.Column<int>(type: "int", nullable: false),
                    OverallRating = table.Column<double>(type: "float", nullable: false),
                    Pros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cons = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdviceToManagement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyReviews_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "About", "CompanySize", "CreatedAt", "FoundedYear", "Headquarters", "Industry", "LogoUrl", "Name", "Website" },
                values: new object[,]
                {
                    { 1, "Global IT services", "500,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9100), 1968, "Mumbai, India", "IT Services", "https://logo.clearbit.com/tcs.com", "TCS", "https://www.tcs.com" },
                    { 2, "Consulting & IT services", "300,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9126), 1981, "Bengaluru, India", "IT Services", "https://logo.clearbit.com/infosys.com", "Infosys", "https://www.infosys.com" },
                    { 3, "IT & consulting", "250,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9133), 1945, "Bengaluru, India", "IT Services", "https://logo.clearbit.com/wipro.com", "Wipro", "https://www.wipro.com" },
                    { 4, "Global IT enterprise", "220,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9138), 1976, "Noida, India", "IT Services", "https://logo.clearbit.com/hcltech.com", "HCL Technologies", "https://www.hcltech.com" },
                    { 5, "Digital transformation", "150,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9143), 1986, "Pune, India", "IT Services", "https://logo.clearbit.com/techmahindra.com", "Tech Mahindra", "https://www.techmahindra.com" },
                    { 6, "Professional services", "700,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9149), 1989, "Dublin, Ireland", "Consulting", "https://logo.clearbit.com/accenture.com", "Accenture", "https://www.accenture.com" },
                    { 7, "IT consulting", "350,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9154), 1967, "Paris, France", "Consulting", "https://logo.clearbit.com/capgemini.com", "Capgemini", "https://www.capgemini.com" },
                    { 8, "Digital transformation", "300,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9158), 1994, "New Jersey, USA", "IT Services", "https://logo.clearbit.com/cognizant.com", "Cognizant", "https://www.cognizant.com" },
                    { 9, "Enterprise tech solutions", "280,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9163), 1911, "New York, USA", "Technology", "https://logo.clearbit.com/ibm.com", "IBM", "https://www.ibm.com" },
                    { 10, "Cloud & AI products", "220,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9168), 1975, "Redmond, USA", "Software", "https://logo.clearbit.com/microsoft.com", "Microsoft", "https://www.microsoft.com" },
                    { 11, "Search & AI", "190,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9173), 1998, "California, USA", "Technology", "https://logo.clearbit.com/google.com", "Google", "https://www.google.com" },
                    { 12, "AWS & retail", "1,500,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9178), 1994, "Seattle, USA", "Cloud & E-commerce", "https://logo.clearbit.com/amazon.com", "Amazon", "https://www.amazon.com" },
                    { 13, "Database solutions", "160,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9183), 1977, "Texas, USA", "Enterprise Software", "https://logo.clearbit.com/oracle.com", "Oracle", "https://www.oracle.com" },
                    { 14, "ERP solutions", "110,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9188), 1972, "Germany", "Enterprise Software", "https://logo.clearbit.com/sap.com", "SAP", "https://www.sap.com" },
                    { 15, "Business software", "12,000+", new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9193), 1996, "Chennai, India", "Software", "https://logo.clearbit.com/zoho.com", "Zoho", "https://www.zoho.com" }
                });

            migrationBuilder.InsertData(
                table: "CompanyRatingSummaries",
                columns: new[] { "Id", "AvgCareerGrowth", "AvgCompensation", "AvgCulture", "AvgJobSecurity", "AvgManagement", "AvgOverallRating", "AvgWorkLifeBalance", "CompanyId", "LastUpdated", "TotalReviews" },
                values: new object[,]
                {
                    { 1, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 1, new DateTime(2026, 1, 27, 5, 32, 31, 47, DateTimeKind.Utc).AddTicks(9971), 100 },
                    { 2, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 2, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(37), 200 },
                    { 3, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 3, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(87), 300 },
                    { 4, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 4, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(132), 400 },
                    { 5, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 5, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(174), 500 },
                    { 6, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 6, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(231), 600 },
                    { 7, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 7, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(274), 700 },
                    { 8, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 8, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(314), 800 },
                    { 9, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 9, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(360), 900 },
                    { 10, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 10, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(414), 1000 },
                    { 11, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 11, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(460), 1100 },
                    { 12, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 12, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(508), 1200 },
                    { 13, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 13, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(560), 1300 },
                    { 14, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 14, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(608), 1400 },
                    { 15, 3.7999999999999998, 3.7000000000000002, 3.8999999999999999, 4.0, 3.5, 3.5, 3.6000000000000001, 15, new DateTime(2026, 1, 27, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(650), 1500 }
                });

            migrationBuilder.InsertData(
                table: "CompanyReviews",
                columns: new[] { "Id", "AdviceToManagement", "CareerGrowth", "CompanyId", "CompensationBenefits", "Cons", "CreatedAt", "Culture", "EmploymentStatus", "IsAnonymous", "IsApproved", "JobSecurity", "JobTitle", "Location", "Management", "OverallRating", "Pros", "WorkLifeBalance" },
                values: new object[,]
                {
                    { 1, "Improve hikes", 3, 1, 3, "Slow growth", new DateTime(2025, 12, 28, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(739), 4, "Current Employee", true, true, 5, "Software Engineer", "Pune", 4, 4.0, "Job security", 3 },
                    { 2, "Maintain balance", 5, 10, 5, "High workload", new DateTime(2026, 1, 17, 5, 32, 31, 48, DateTimeKind.Utc).AddTicks(762), 5, "Current Employee", false, true, 5, "Senior Developer", "Hyderabad", 4, 4.7999999999999998, "Pay & culture", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRatingSummaries_CompanyId",
                table: "CompanyRatingSummaries",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyReviews_CompanyId",
                table: "CompanyReviews",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyRatingSummaries");

            migrationBuilder.DropTable(
                name: "CompanyReviews");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
