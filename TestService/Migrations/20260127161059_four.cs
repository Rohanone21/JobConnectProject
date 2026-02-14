using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestService.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "McqOptions",
                columns: new[] { "Id", "IsCorrect", "McqQuestionId", "OptionText" },
                values: new object[,]
                {
                    { 13, true, 4, "Queue" },
                    { 14, false, 4, "Stack" },
                    { 15, false, 4, "Array" },
                    { 16, false, 4, "Tree" },
                    { 17, true, 5, "Representational State Transfer" },
                    { 18, false, 5, "Remote Server Technology" },
                    { 19, false, 5, "Rapid Execution System" },
                    { 20, false, 5, "Random Storage" },
                    { 21, true, 6, "Microsoft" },
                    { 22, false, 6, "Google" },
                    { 23, false, 6, "Apple" },
                    { 24, false, 6, "Oracle" },
                    { 25, true, 7, "Common Language Runtime" },
                    { 26, false, 7, "C Language Runtime" },
                    { 27, false, 7, "Common Library Reference" },
                    { 28, false, 7, "Compiler Level Runtime" },
                    { 29, true, 8, "C#" },
                    { 30, false, 8, "Java" },
                    { 31, false, 8, "Python" },
                    { 32, false, 8, "Ruby" },
                    { 33, true, 9, "Language Integrated Query" },
                    { 34, false, 9, "Local Internet Query" },
                    { 35, false, 9, "Logical Information Queue" },
                    { 36, false, 9, "Library Integration" },
                    { 37, true, 10, "SQL Server" },
                    { 38, false, 10, "MySQL" },
                    { 39, false, 10, "PostgreSQL" },
                    { 40, false, 10, "MongoDB" }
                });

            migrationBuilder.InsertData(
                table: "McqQuestions",
                columns: new[] { "Id", "McqTestId", "QuestionText" },
                values: new object[,]
                {
                    { 11, 3, "What is AWS?" },
                    { 12, 3, "Which is Amazon's cloud computing platform?" },
                    { 13, 3, "What is DynamoDB?" },
                    { 14, 3, "What does EC2 stand for?" },
                    { 15, 3, "Which AWS service is for object storage?" },
                    { 16, 4, "React was developed by?" },
                    { 17, 4, "What is GraphQL?" },
                    { 18, 4, "Which database does Facebook use?" },
                    { 19, 4, "What is React Native?" },
                    { 20, 4, "What does FBML stand for?" },
                    { 21, 5, "What is Chaos Monkey?" },
                    { 22, 5, "Which cloud provider does Netflix use?" },
                    { 23, 5, "What is Microservices architecture?" },
                    { 24, 5, "Which tool is used for service discovery?" },
                    { 25, 5, "What is Hystrix?" }
                });

            migrationBuilder.InsertData(
                table: "McqTests",
                columns: new[] { "Id", "CompanyId", "DurationMinutes", "IsActive", "Title", "TotalQuestions" },
                values: new object[,]
                {
                    { 6, 6, 30, true, "Apple MCQ Test", 5 },
                    { 7, 7, 30, true, "Tesla MCQ Test", 5 },
                    { 8, 8, 30, true, "IBM MCQ Test", 5 },
                    { 9, 9, 30, true, "Oracle MCQ Test", 5 },
                    { 10, 10, 30, true, "Adobe MCQ Test", 5 },
                    { 11, 11, 30, true, "Salesforce MCQ Test", 5 },
                    { 12, 12, 30, true, "Uber MCQ Test", 5 },
                    { 13, 13, 30, true, "Airbnb MCQ Test", 5 },
                    { 14, 14, 30, true, "Spotify MCQ Test", 5 },
                    { 15, 15, 30, true, "Twitter/X MCQ Test", 5 },
                    { 16, 16, 30, true, "LinkedIn MCQ Test", 5 },
                    { 17, 17, 30, true, "Intel MCQ Test", 5 },
                    { 18, 18, 30, true, "Cisco MCQ Test", 5 },
                    { 19, 19, 30, true, "PayPal MCQ Test", 5 },
                    { 20, 20, 30, true, "Stripe MCQ Test", 5 }
                });

            migrationBuilder.InsertData(
                table: "McqOptions",
                columns: new[] { "Id", "IsCorrect", "McqQuestionId", "OptionText" },
                values: new object[,]
                {
                    { 41, true, 11, "Amazon Web Services" },
                    { 42, false, 11, "Advanced Web System" },
                    { 43, false, 11, "Amazon Work Station" },
                    { 44, false, 11, "Application Web Service" },
                    { 45, true, 12, "AWS" },
                    { 46, false, 12, "Azure" },
                    { 47, false, 12, "GCP" },
                    { 48, false, 12, "IBM Cloud" },
                    { 49, true, 13, "NoSQL database" },
                    { 50, false, 13, "SQL database" },
                    { 51, false, 13, "Cache system" },
                    { 52, false, 13, "File storage" },
                    { 53, true, 14, "Elastic Compute Cloud" },
                    { 54, false, 14, "Enterprise Cloud Computing" },
                    { 55, false, 14, "Elastic Cache Cloud" },
                    { 56, false, 14, "Extended Cloud Compute" },
                    { 57, true, 15, "S3" },
                    { 58, false, 15, "EC2" },
                    { 59, false, 15, "Lambda" },
                    { 60, false, 15, "RDS" },
                    { 61, true, 16, "Facebook" },
                    { 62, false, 16, "Google" },
                    { 63, false, 16, "Microsoft" },
                    { 64, false, 16, "Apple" },
                    { 65, true, 17, "Query language for APIs" },
                    { 66, false, 17, "Graph database" },
                    { 67, false, 17, "Charting library" },
                    { 68, false, 17, "Graphics library" },
                    { 69, true, 18, "MySQL" },
                    { 70, false, 18, "MongoDB" },
                    { 71, false, 18, "Oracle" },
                    { 72, false, 18, "PostgreSQL" },
                    { 73, true, 19, "Mobile framework" },
                    { 74, false, 19, "Database" },
                    { 75, false, 19, "Programming language" },
                    { 76, false, 19, "Cloud service" },
                    { 77, true, 20, "Facebook Markup Language" },
                    { 78, false, 20, "Fast Binary ML" },
                    { 79, false, 20, "File Based Markup" },
                    { 80, false, 20, "Facebook Binary Language" },
                    { 81, true, 21, "Chaos engineering tool" },
                    { 82, false, 21, "Game" },
                    { 83, false, 21, "Testing framework" },
                    { 84, false, 21, "Monitoring tool" },
                    { 85, true, 22, "AWS" },
                    { 86, false, 22, "Azure" },
                    { 87, false, 22, "GCP" },
                    { 88, false, 22, "IBM" },
                    { 89, true, 23, "Architectural style" },
                    { 90, false, 23, "Programming language" },
                    { 91, false, 23, "Database" },
                    { 92, false, 23, "Framework" },
                    { 93, true, 24, "Eureka" },
                    { 94, false, 24, "Redis" },
                    { 95, false, 24, "Kafka" },
                    { 96, false, 24, "Zookeeper" },
                    { 97, true, 25, "Latency and fault tolerance library" },
                    { 98, false, 25, "Database" },
                    { 99, false, 25, "Programming language" },
                    { 100, false, 25, "Cloud service" }
                });

            migrationBuilder.InsertData(
                table: "McqQuestions",
                columns: new[] { "Id", "McqTestId", "QuestionText" },
                values: new object[,]
                {
                    { 26, 6, "Which language is used for iOS development?" },
                    { 27, 6, "What is Swift?" },
                    { 28, 6, "What is Xcode?" },
                    { 29, 6, "Which Apple framework is for AR?" },
                    { 30, 6, "What is Core Data?" },
                    { 31, 7, "What programming language does Tesla use for Autopilot?" },
                    { 32, 7, "What is Tesla's operating system?" },
                    { 33, 7, "Which AI chip does Tesla develop?" },
                    { 34, 7, "What is Dojo?" },
                    { 35, 7, "Which company's hardware does Tesla use for FSD?" },
                    { 36, 8, "What is Watson?" },
                    { 37, 8, "Which database is from IBM?" },
                    { 38, 8, "What is IBM Cloud?" },
                    { 39, 8, "What does COBOL stand for?" },
                    { 40, 8, "Which programming language did IBM develop?" },
                    { 41, 9, "What is Oracle Database?" },
                    { 42, 9, "Which language is PL/SQL based on?" },
                    { 43, 9, "What is Java's relationship with Oracle?" },
                    { 44, 9, "What is MySQL?" },
                    { 45, 9, "Which tool is Oracle's ERP?" },
                    { 46, 10, "What is Photoshop's file format?" },
                    { 47, 10, "Which language is used in Adobe Flash?" },
                    { 48, 10, "What is PDF?" },
                    { 49, 10, "Which Adobe tool is for video editing?" },
                    { 50, 10, "What is Creative Cloud?" },
                    { 51, 11, "What is Apex?" },
                    { 52, 11, "Which language is similar to Apex?" },
                    { 53, 11, "What is Salesforce CRM?" },
                    { 54, 11, "What does SOQL stand for?" },
                    { 55, 11, "Which database does Salesforce use?" },
                    { 56, 12, "What programming language is Uber's backend in?" },
                    { 57, 12, "Which database does Uber use?" },
                    { 58, 12, "What is Uber's mapping technology?" },
                    { 59, 12, "What is ETA?" },
                    { 60, 12, "Which algorithm is used for ride matching?" },
                    { 61, 13, "Which framework does Airbnb use?" },
                    { 62, 13, "What is Airflow?" },
                    { 63, 13, "Which database does Airbnb use?" },
                    { 64, 13, "What is Airbnb's design system?" },
                    { 65, 13, "Which cloud provider does Airbnb use?" },
                    { 66, 14, "What is Spotify's backend language?" },
                    { 67, 14, "Which database does Spotify use?" },
                    { 68, 14, "What is Spotify's recommendation algorithm?" },
                    { 69, 14, "What is Lucio?" },
                    { 70, 14, "Which protocol does Spotify use for streaming?" },
                    { 71, 15, "Which framework does Twitter use?" },
                    { 72, 15, "What is Finagle?" },
                    { 73, 15, "Which database does Twitter use?" },
                    { 74, 15, "What is Snowflake ID?" },
                    { 75, 15, "Which language is Twitter's backend in?" },
                    { 76, 16, "Which framework does LinkedIn use?" },
                    { 77, 16, "What is Kafka?" },
                    { 78, 16, "Which database does LinkedIn use?" },
                    { 79, 16, "What is Pinot?" },
                    { 80, 16, "Which language is LinkedIn's backend in?" },
                    { 81, 17, "What is x86 architecture?" },
                    { 82, 17, "Which instruction set does Intel use?" },
                    { 83, 17, "What is Intel's competitor?" },
                    { 84, 17, "What is SIMD?" },
                    { 85, 17, "Which Intel technology boosts performance?" },
                    { 86, 18, "What is Cisco's main business?" },
                    { 87, 18, "What is IOS?" },
                    { 88, 18, "What is a router?" },
                    { 89, 18, "What does VPN stand for?" },
                    { 90, 18, "Which protocol does Cisco develop?" },
                    { 91, 19, "Which language does PayPal use?" },
                    { 92, 19, "What is Braintree?" },
                    { 93, 19, "Which database does PayPal use?" },
                    { 94, 19, "What is PayPal's security protocol?" },
                    { 95, 19, "What does PCI DSS stand for?" },
                    { 96, 20, "Which language does Stripe use?" },
                    { 97, 20, "What is Stripe's main product?" },
                    { 98, 20, "What is Stripe Connect?" },
                    { 99, 20, "Which database does Stripe use?" },
                    { 100, 20, "What is Stripe Radar?" }
                });

            migrationBuilder.InsertData(
                table: "McqOptions",
                columns: new[] { "Id", "IsCorrect", "McqQuestionId", "OptionText" },
                values: new object[,]
                {
                    { 101, true, 26, "Swift" },
                    { 102, false, 26, "Java" },
                    { 103, false, 26, "Kotlin" },
                    { 104, false, 26, "C++" },
                    { 105, true, 27, "Programming language" },
                    { 106, false, 27, "Database" },
                    { 107, false, 27, "Framework" },
                    { 108, false, 27, "Operating system" },
                    { 109, true, 28, "IDE" },
                    { 110, false, 28, "Programming language" },
                    { 111, false, 28, "Database" },
                    { 112, false, 28, "Cloud service" },
                    { 113, true, 29, "ARKit" },
                    { 114, false, 29, "Core ML" },
                    { 115, false, 29, "Metal" },
                    { 116, false, 29, "SwiftUI" },
                    { 117, true, 30, "Persistence framework" },
                    { 118, false, 30, "Networking library" },
                    { 119, false, 30, "UI framework" },
                    { 120, false, 30, "Testing framework" },
                    { 121, true, 31, "Python" },
                    { 122, false, 31, "Java" },
                    { 123, false, 31, "C++" },
                    { 124, false, 31, "Rust" },
                    { 125, true, 32, "Linux based" },
                    { 126, false, 32, "Windows based" },
                    { 127, false, 32, "MacOS based" },
                    { 128, false, 32, "Android based" },
                    { 129, true, 33, "D1" },
                    { 130, false, 33, "A1" },
                    { 131, false, 33, "B1" },
                    { 132, false, 33, "C1" },
                    { 133, true, 34, "Training computer" },
                    { 134, false, 34, "Car model" },
                    { 135, false, 34, "Software update" },
                    { 136, false, 34, "Battery type" },
                    { 137, true, 35, "NVIDIA" },
                    { 138, false, 35, "Intel" },
                    { 139, false, 35, "AMD" },
                    { 140, false, 35, "Qualcomm" },
                    { 141, true, 36, "AI platform" },
                    { 142, false, 36, "Database" },
                    { 143, false, 36, "Programming language" },
                    { 144, false, 36, "Operating system" },
                    { 145, true, 37, "DB2" },
                    { 146, false, 37, "MySQL" },
                    { 147, false, 37, "PostgreSQL" },
                    { 148, false, 37, "Oracle" },
                    { 149, true, 38, "Cloud platform" },
                    { 150, false, 38, "IDE" },
                    { 151, false, 38, "Database" },
                    { 152, false, 38, "Framework" },
                    { 153, true, 39, "Common Business Oriented Language" },
                    { 154, false, 39, "Computer Business Language" },
                    { 155, false, 39, "Common Binary Language" },
                    { 156, false, 39, "Corporate Business Language" },
                    { 157, true, 40, "FORTRAN" },
                    { 158, false, 40, "Java" },
                    { 159, false, 40, "Python" },
                    { 160, false, 40, "C++" },
                    { 161, true, 41, "RDBMS" },
                    { 162, false, 41, "NoSQL database" },
                    { 163, false, 41, "Programming language" },
                    { 164, false, 41, "Framework" },
                    { 165, true, 42, "SQL" },
                    { 166, false, 42, "Java" },
                    { 167, false, 42, "C++" },
                    { 168, false, 42, "Python" },
                    { 169, true, 43, "Oracle owns Java" },
                    { 170, false, 43, "Java owns Oracle" },
                    { 171, false, 43, "No relation" },
                    { 172, false, 43, "Competitors" },
                    { 173, true, 44, "Open source RDBMS" },
                    { 174, false, 44, "NoSQL database" },
                    { 175, false, 44, "Programming language" },
                    { 176, false, 44, "Cloud service" },
                    { 177, true, 45, "Oracle E-Business Suite" },
                    { 178, false, 45, "SAP" },
                    { 179, false, 45, "Salesforce" },
                    { 180, false, 45, "Workday" },
                    { 181, true, 46, "PSD" },
                    { 182, false, 46, "PDF" },
                    { 183, false, 46, "JPG" },
                    { 184, false, 46, "PNG" },
                    { 185, true, 47, "ActionScript" },
                    { 186, false, 47, "JavaScript" },
                    { 187, false, 47, "Python" },
                    { 188, false, 47, "Java" },
                    { 189, true, 48, "Portable Document Format" },
                    { 190, false, 48, "Personal Data File" },
                    { 191, false, 48, "Print Document Format" },
                    { 192, false, 48, "Platform Data File" },
                    { 193, true, 49, "Premiere Pro" },
                    { 194, false, 49, "Photoshop" },
                    { 195, false, 49, "Illustrator" },
                    { 196, false, 49, "After Effects" },
                    { 197, true, 50, "Subscription service" },
                    { 198, false, 50, "Cloud storage" },
                    { 199, false, 50, "Social media" },
                    { 200, false, 50, "E-commerce" },
                    { 201, true, 51, "Programming language" },
                    { 202, false, 51, "Database" },
                    { 203, false, 51, "Framework" },
                    { 204, false, 51, "Cloud service" },
                    { 205, true, 52, "Java" },
                    { 206, false, 52, "Python" },
                    { 207, false, 52, "C#" },
                    { 208, false, 52, "JavaScript" },
                    { 209, true, 53, "Customer Relationship Management" },
                    { 210, false, 53, "Cloud Resource Management" },
                    { 211, false, 53, "Content Relationship Manager" },
                    { 212, false, 53, "Customer Resource Manager" },
                    { 213, true, 54, "Salesforce Object Query Language" },
                    { 214, false, 54, "Structured Object Query Language" },
                    { 215, false, 54, "Salesforce Online Query Language" },
                    { 216, false, 54, "Simple Object Query Language" },
                    { 217, true, 55, "Proprietary database" },
                    { 218, false, 55, "MySQL" },
                    { 219, false, 55, "Oracle" },
                    { 220, false, 55, "PostgreSQL" },
                    { 221, true, 56, "Go" },
                    { 222, false, 56, "Java" },
                    { 223, false, 56, "Python" },
                    { 224, false, 56, "C++" },
                    { 225, true, 57, "PostgreSQL" },
                    { 226, false, 57, "MySQL" },
                    { 227, false, 57, "MongoDB" },
                    { 228, false, 57, "Redis" },
                    { 229, true, 58, "Google Maps" },
                    { 230, false, 58, "Apple Maps" },
                    { 231, false, 58, "OpenStreetMap" },
                    { 232, false, 58, "HERE Maps" },
                    { 233, true, 59, "Estimated Time of Arrival" },
                    { 234, false, 59, "Exact Time of Arrival" },
                    { 235, false, 59, "Expected Time of Arrival" },
                    { 236, false, 59, "Estimated Travel Algorithm" },
                    { 237, true, 60, "Greedy algorithm" },
                    { 238, false, 60, "Dijkstra" },
                    { 239, false, 60, "A*" },
                    { 240, false, 60, "BFS" },
                    { 241, true, 61, "React" },
                    { 242, false, 61, "Angular" },
                    { 243, false, 61, "Vue" },
                    { 244, false, 61, "Ember" },
                    { 245, true, 62, "Workflow scheduler" },
                    { 246, false, 62, "Database" },
                    { 247, false, 62, "Programming language" },
                    { 248, false, 62, "Cloud service" },
                    { 249, true, 63, "MySQL" },
                    { 250, false, 63, "PostgreSQL" },
                    { 251, false, 63, "MongoDB" },
                    { 252, false, 63, "Redis" },
                    { 253, true, 64, "DLS" },
                    { 254, false, 64, "Bootstrap" },
                    { 255, false, 64, "Material UI" },
                    { 256, false, 64, "Tailwind" },
                    { 257, true, 65, "AWS" },
                    { 258, false, 65, "Azure" },
                    { 259, false, 65, "GCP" },
                    { 260, false, 65, "IBM" },
                    { 261, true, 66, "Python" },
                    { 262, false, 66, "Java" },
                    { 263, false, 66, "Go" },
                    { 264, false, 66, "C++" },
                    { 265, true, 67, "Cassandra" },
                    { 266, false, 67, "MySQL" },
                    { 267, false, 67, "PostgreSQL" },
                    { 268, false, 67, "MongoDB" },
                    { 269, true, 68, "Collaborative filtering" },
                    { 270, false, 68, "Decision trees" },
                    { 271, false, 68, "Neural networks" },
                    { 272, false, 68, "Linear regression" },
                    { 273, true, 69, "Audio codec" },
                    { 274, false, 69, "Database" },
                    { 275, false, 69, "Framework" },
                    { 276, false, 69, "Programming language" },
                    { 277, true, 70, "HTTP" },
                    { 278, false, 70, "FTP" },
                    { 279, false, 70, "RTMP" },
                    { 280, false, 70, "UDP" },
                    { 281, true, 71, "Ruby on Rails" },
                    { 282, false, 71, "Django" },
                    { 283, false, 71, "Spring" },
                    { 284, false, 71, "Laravel" },
                    { 285, true, 72, "RPC framework" },
                    { 286, false, 72, "Database" },
                    { 287, false, 72, "Programming language" },
                    { 288, false, 72, "Cloud service" },
                    { 289, true, 73, "MySQL" },
                    { 290, false, 73, "PostgreSQL" },
                    { 291, false, 73, "MongoDB" },
                    { 292, false, 73, "Cassandra" },
                    { 293, true, 74, "Distributed ID generator" },
                    { 294, false, 74, "Database" },
                    { 295, false, 74, "Framework" },
                    { 296, false, 74, "Cloud service" },
                    { 297, true, 75, "Scala" },
                    { 298, false, 75, "Java" },
                    { 299, false, 75, "Python" },
                    { 300, false, 75, "Ruby" },
                    { 301, true, 76, "Play Framework" },
                    { 302, false, 76, "Spring" },
                    { 303, false, 76, "Django" },
                    { 304, false, 76, "Express" },
                    { 305, true, 77, "Distributed streaming platform" },
                    { 306, false, 77, "Database" },
                    { 307, false, 77, "Programming language" },
                    { 308, false, 77, "Cloud service" },
                    { 309, true, 78, "Espresso" },
                    { 310, false, 78, "MySQL" },
                    { 311, false, 78, "PostgreSQL" },
                    { 312, false, 78, "Oracle" },
                    { 313, true, 79, "Real-time analytics database" },
                    { 314, false, 79, "Programming language" },
                    { 315, false, 79, "Framework" },
                    { 316, false, 79, "Cloud service" },
                    { 317, true, 80, "Java" },
                    { 318, false, 80, "Python" },
                    { 319, false, 80, "Go" },
                    { 320, false, 80, "C++" },
                    { 321, true, 81, "CPU architecture" },
                    { 322, false, 81, "GPU architecture" },
                    { 323, false, 81, "Networking protocol" },
                    { 324, false, 81, "Programming language" },
                    { 325, true, 82, "x86" },
                    { 326, false, 82, "ARM" },
                    { 327, false, 82, "RISC-V" },
                    { 328, false, 82, "MIPS" },
                    { 329, true, 83, "AMD" },
                    { 330, false, 83, "NVIDIA" },
                    { 331, false, 83, "Qualcomm" },
                    { 332, false, 83, "Apple" },
                    { 333, true, 84, "Single Instruction Multiple Data" },
                    { 334, false, 84, "Single Instruction Single Data" },
                    { 335, false, 84, "Multiple Instruction Single Data" },
                    { 336, false, 84, "Multiple Instruction Multiple Data" },
                    { 337, true, 85, "Hyper-Threading" },
                    { 338, false, 85, "Turbo Boost" },
                    { 339, false, 85, "Virtualization" },
                    { 340, false, 85, "Overclocking" },
                    { 341, true, 86, "Networking hardware" },
                    { 342, false, 86, "Software development" },
                    { 343, false, 86, "Cloud services" },
                    { 344, false, 86, "Consumer electronics" },
                    { 345, true, 87, "Internetwork Operating System" },
                    { 346, false, 87, "International Operating System" },
                    { 347, false, 87, "Internet Operating System" },
                    { 348, false, 87, "Integrated Operating System" },
                    { 349, true, 88, "Networking device" },
                    { 350, false, 88, "Storage device" },
                    { 351, false, 88, "Security device" },
                    { 352, false, 88, "Compute device" },
                    { 353, true, 89, "Virtual Private Network" },
                    { 354, false, 89, "Virtual Public Network" },
                    { 355, false, 89, "Verified Private Network" },
                    { 356, false, 89, "Virtual Protocol Network" },
                    { 357, true, 90, "CCNP" },
                    { 358, false, 90, "TCP/IP" },
                    { 359, false, 90, "HTTP" },
                    { 360, false, 90, "FTP" },
                    { 361, true, 91, "Java" },
                    { 362, false, 91, "Python" },
                    { 363, false, 91, "C++" },
                    { 364, false, 91, "Ruby" },
                    { 365, true, 92, "Payment gateway" },
                    { 366, false, 92, "Bank" },
                    { 367, false, 92, "Cryptocurrency" },
                    { 368, false, 92, "Trading platform" },
                    { 369, true, 93, "MySQL" },
                    { 370, false, 93, "PostgreSQL" },
                    { 371, false, 93, "Oracle" },
                    { 372, false, 93, "MongoDB" },
                    { 373, true, 94, "Two-factor authentication" },
                    { 374, false, 94, "SSL" },
                    { 375, false, 94, "Firewall" },
                    { 376, false, 94, "VPN" },
                    { 377, true, 95, "Payment Card Industry Data Security Standard" },
                    { 378, false, 95, "Payment Card International Data Standard" },
                    { 379, false, 95, "Personal Card Information Data Security" },
                    { 380, false, 95, "Payment Card Information Data Security" },
                    { 381, true, 96, "Ruby" },
                    { 382, false, 96, "Java" },
                    { 383, false, 96, "Python" },
                    { 384, false, 96, "Go" },
                    { 385, true, 97, "Payment processing" },
                    { 386, false, 97, "Banking" },
                    { 387, false, 97, "Insurance" },
                    { 388, false, 97, "Trading" },
                    { 389, true, 98, "Platform for marketplaces" },
                    { 390, false, 98, "Banking service" },
                    { 391, false, 98, "Investment platform" },
                    { 392, false, 98, "Cryptocurrency wallet" },
                    { 393, true, 99, "PostgreSQL" },
                    { 394, false, 99, "MySQL" },
                    { 395, false, 99, "MongoDB" },
                    { 396, false, 99, "Redis" },
                    { 397, true, 100, "Fraud prevention" },
                    { 398, false, 100, "Payment gateway" },
                    { 399, false, 100, "Banking service" },
                    { 400, false, 100, "Analytics tool" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "McqOptions",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "McqQuestions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "McqTests",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
