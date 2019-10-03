using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class exams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "examsmanagement",
                columns: table => new
                {
                    ExaminationIncharge = table.Column<string>(nullable: false),
                    subjects = table.Column<string>(nullable: true),
                    marksinfo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examsmanagement", x => x.ExaminationIncharge);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "examsmanagement");
        }
    }
}
