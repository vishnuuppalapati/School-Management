using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class libraryrelateddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "StudentsInfos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofBirth",
                table: "StudentsInfos",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "StudentsInfos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Adminname = table.Column<string>(nullable: false),
                    Avlblesubjectbooks = table.Column<string>(nullable: true),
                    SubjectAuthorslist = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Adminname);
                });

            migrationBuilder.CreateTable(
                name: "subjectmanagements",
                columns: table => new
                {
                    subjectname = table.Column<string>(nullable: false),
                    subjectteacher = table.Column<string>(nullable: true),
                    referencebook = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectmanagements", x => x.subjectname);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libraries");

            migrationBuilder.DropTable(
                name: "subjectmanagements");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "StudentsInfos");

            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "StudentsInfos");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "StudentsInfos");
        }
    }
}
