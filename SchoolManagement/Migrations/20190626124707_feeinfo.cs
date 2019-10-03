using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class feeinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_subjectmanagements",
                table: "subjectmanagements");

            migrationBuilder.RenameTable(
                name: "subjectmanagements",
                newName: "Subjectmanagements");

            migrationBuilder.RenameColumn(
                name: "subjectteacher",
                table: "Subjectmanagements",
                newName: "Subjectteacher");

            migrationBuilder.RenameColumn(
                name: "subjectname",
                table: "Subjectmanagements",
                newName: "Subjectname");

            migrationBuilder.RenameColumn(
                name: "referencebook",
                table: "Subjectmanagements",
                newName: "Seferencebook");

            migrationBuilder.RenameColumn(
                name: "subjects",
                table: "examsmanagement",
                newName: "Subjects");

            migrationBuilder.RenameColumn(
                name: "marksinfo",
                table: "examsmanagement",
                newName: "Marksinfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjectmanagements",
                table: "Subjectmanagements",
                column: "Subjectname");

            migrationBuilder.CreateTable(
                name: "Feeinformation",
                columns: table => new
                {
                    Class5 = table.Column<string>(nullable: false),
                    Class6 = table.Column<string>(nullable: true),
                    Class7 = table.Column<string>(nullable: true),
                    Class8 = table.Column<string>(nullable: true),
                    Class9 = table.Column<string>(nullable: true),
                    Class10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeinformation", x => x.Class5);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feeinformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjectmanagements",
                table: "Subjectmanagements");

            migrationBuilder.RenameTable(
                name: "Subjectmanagements",
                newName: "subjectmanagements");

            migrationBuilder.RenameColumn(
                name: "Subjectteacher",
                table: "subjectmanagements",
                newName: "subjectteacher");

            migrationBuilder.RenameColumn(
                name: "Subjectname",
                table: "subjectmanagements",
                newName: "subjectname");

            migrationBuilder.RenameColumn(
                name: "Seferencebook",
                table: "subjectmanagements",
                newName: "referencebook");

            migrationBuilder.RenameColumn(
                name: "Subjects",
                table: "examsmanagement",
                newName: "subjects");

            migrationBuilder.RenameColumn(
                name: "Marksinfo",
                table: "examsmanagement",
                newName: "marksinfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subjectmanagements",
                table: "subjectmanagements",
                column: "subjectname");
        }
    }
}
