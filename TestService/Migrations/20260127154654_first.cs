using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestService.Migrations
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "McqTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TotalQuestions = table.Column<int>(type: "int", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_McqTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_McqTests_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateTestAttempts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    McqTestId = table.Column<int>(type: "int", nullable: false),
                    CandidateEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateTestAttempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateTestAttempts_McqTests_McqTestId",
                        column: x => x.McqTestId,
                        principalTable: "McqTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "McqQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    McqTestId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_McqQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_McqQuestions_McqTests_McqTestId",
                        column: x => x.McqTestId,
                        principalTable: "McqTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "McqOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    McqQuestionId = table.Column<int>(type: "int", nullable: false),
                    OptionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_McqOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_McqOptions_McqQuestions_McqQuestionId",
                        column: x => x.McqQuestionId,
                        principalTable: "McqQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Google" },
                    { 2, "Microsoft" },
                    { 3, "Amazon" },
                    { 4, "Meta" },
                    { 5, "Netflix" },
                    { 6, "Apple" },
                    { 7, "Tesla" },
                    { 8, "IBM" },
                    { 9, "Oracle" },
                    { 10, "Adobe" },
                    { 11, "Salesforce" },
                    { 12, "Uber" },
                    { 13, "Airbnb" },
                    { 14, "Spotify" },
                    { 15, "Twitter/X" },
                    { 16, "LinkedIn" },
                    { 17, "Intel" },
                    { 18, "Cisco" },
                    { 19, "PayPal" },
                    { 20, "Stripe" }
                });

            migrationBuilder.InsertData(
                table: "McqTests",
                columns: new[] { "Id", "CompanyId", "DurationMinutes", "IsActive", "Title", "TotalQuestions" },
                values: new object[,]
                {
                    { 1, 1, 30, true, "Google MCQ Test", 5 },
                    { 2, 2, 30, true, "Microsoft MCQ Test", 5 },
                    { 3, 3, 30, true, "Amazon MCQ Test", 5 },
                    { 4, 4, 30, true, "Meta MCQ Test", 5 },
                    { 5, 5, 30, true, "Netflix MCQ Test", 5 }
                });

            migrationBuilder.InsertData(
                table: "McqQuestions",
                columns: new[] { "Id", "McqTestId", "QuestionText" },
                values: new object[,]
                {
                    { 1, 1, "What is Big-O notation used for?" },
                    { 2, 1, "Which language is Android primarily written in?" },
                    { 3, 1, "What does JVM stand for?" },
                    { 4, 1, "Which data structure uses FIFO?" },
                    { 5, 1, "What is REST?" },
                    { 6, 2, ".NET is developed by?" },
                    { 7, 2, "What is CLR?" },
                    { 8, 2, "Which language is used with ASP.NET Core?" },
                    { 9, 2, "What does LINQ stand for?" },
                    { 10, 2, "Which DB is from Microsoft?" }
                });

            migrationBuilder.InsertData(
                table: "McqOptions",
                columns: new[] { "Id", "IsCorrect", "McqQuestionId", "OptionText" },
                values: new object[,]
                {
                    { 1, true, 1, "Time complexity analysis" },
                    { 2, false, 1, "UI design" },
                    { 3, false, 1, "Database indexing" },
                    { 4, false, 1, "Networking protocol" },
                    { 5, true, 2, "Java" },
                    { 6, false, 2, "Python" },
                    { 7, false, 2, "Swift" },
                    { 8, false, 2, "Go" },
                    { 9, true, 3, "Java Virtual Machine" },
                    { 10, false, 3, "Java Variable Method" },
                    { 11, false, 3, "Just Virtual Memory" },
                    { 12, false, 3, "None" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateTestAttempts_McqTestId",
                table: "CandidateTestAttempts",
                column: "McqTestId");

            migrationBuilder.CreateIndex(
                name: "IX_McqOptions_McqQuestionId",
                table: "McqOptions",
                column: "McqQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_McqQuestions_McqTestId",
                table: "McqQuestions",
                column: "McqTestId");

            migrationBuilder.CreateIndex(
                name: "IX_McqTests_CompanyId",
                table: "McqTests",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateTestAttempts");

            migrationBuilder.DropTable(
                name: "McqOptions");

            migrationBuilder.DropTable(
                name: "McqQuestions");

            migrationBuilder.DropTable(
                name: "McqTests");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
