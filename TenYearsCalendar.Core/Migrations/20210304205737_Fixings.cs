using Microsoft.EntityFrameworkCore.Migrations;

namespace TenYearsCalendar.Core.Migrations
{
    public partial class Fixings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Months",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Days",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "YearAppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearAppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YearAppUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YearAppUser_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Months_AppUserId",
                table: "Months",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_AppUserId",
                table: "Days",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_YearAppUser_AppUserId",
                table: "YearAppUser",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_YearAppUser_YearId",
                table: "YearAppUser",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_AspNetUsers_AppUserId",
                table: "Days",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Months_AspNetUsers_AppUserId",
                table: "Months",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_AspNetUsers_AppUserId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Months_AspNetUsers_AppUserId",
                table: "Months");

            migrationBuilder.DropTable(
                name: "YearAppUser");

            migrationBuilder.DropIndex(
                name: "IX_Months_AppUserId",
                table: "Months");

            migrationBuilder.DropIndex(
                name: "IX_Days_AppUserId",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Months");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Days");
        }
    }
}
