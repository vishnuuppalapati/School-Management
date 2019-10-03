using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class attendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendanceinfos",
                columns: table => new
                {
                    AttendAdmin = table.Column<string>(nullable: false),
                    NoOfWorkingdays = table.Column<int>(nullable: false),
                    NoOfPresentdays = table.Column<int>(nullable: false),
                    NoOfAbsentdays = table.Column<int>(nullable: false),
                    AttendencePercentage = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendanceinfos", x => x.AttendAdmin);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendanceinfos");
        }
    }
}
