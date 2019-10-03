using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class addingparentinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentsInfo",
                table: "StudentsInfo");

            migrationBuilder.RenameTable(
                name: "StudentsInfo",
                newName: "StudentsInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentsInfos",
                table: "StudentsInfos",
                column: "studentid");

            migrationBuilder.CreateTable(
                name: "Parentsinfos",
                columns: table => new
                {
                    parent = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentsinfos", x => x.parent);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parentsinfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentsInfos",
                table: "StudentsInfos");

            migrationBuilder.RenameTable(
                name: "StudentsInfos",
                newName: "StudentsInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentsInfo",
                table: "StudentsInfo",
                column: "studentid");
        }
    }
}
