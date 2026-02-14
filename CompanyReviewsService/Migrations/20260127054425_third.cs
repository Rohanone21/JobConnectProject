using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyReviewsService.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRatingSummaries_Companies_CompanyId",
                table: "CompanyRatingSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyReviews_Companies_CompanyId",
                table: "CompanyReviews");

            migrationBuilder.DropIndex(
                name: "IX_CompanyReviews_CompanyId",
                table: "CompanyReviews");

            migrationBuilder.DropIndex(
                name: "IX_CompanyRatingSummaries_CompanyId",
                table: "CompanyRatingSummaries");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CompanyReviews");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CompanyRatingSummaries");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CompanyReviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CompanyRatingSummaries",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 27, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "CompanyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 28, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "CompanyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 5, 44, 24, 762, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyRatingSummaries_Companies_Id",
                table: "CompanyRatingSummaries",
                column: "Id",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyReviews_Companies_Id",
                table: "CompanyReviews",
                column: "Id",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRatingSummaries_Companies_Id",
                table: "CompanyRatingSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyReviews_Companies_Id",
                table: "CompanyReviews");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CompanyReviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CompanyReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CompanyRatingSummaries",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CompanyRatingSummaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 1, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 2, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 3, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 4, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 5, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 6, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 7, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 8, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 9, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 10, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 11, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 12, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 13, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 14, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "CompanyRatingSummaries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "LastUpdated" },
                values: new object[] { 15, new DateTime(2026, 1, 27, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "CompanyReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2025, 12, 28, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "CompanyReviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "CreatedAt" },
                values: new object[] { 10, new DateTime(2026, 1, 17, 5, 35, 56, 252, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyReviews_CompanyId",
                table: "CompanyReviews",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRatingSummaries_CompanyId",
                table: "CompanyRatingSummaries",
                column: "CompanyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyRatingSummaries_Companies_CompanyId",
                table: "CompanyRatingSummaries",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyReviews_Companies_CompanyId",
                table: "CompanyReviews",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
