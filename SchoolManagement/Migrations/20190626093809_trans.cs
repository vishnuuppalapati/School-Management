using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class trans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "parent",
                table: "StudentsInfos",
                newName: "parentname");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "StaffInfos",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "StaffInfos",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StaffInfos",
                newName: "FacultyName");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "StaffInfos",
                newName: "FacultyAddress");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Parentsinfos",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Parentsinfos",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "parent",
                table: "Parentsinfos",
                newName: "parentname");

            migrationBuilder.CreateTable(
                name: "Transportationinfos",
                columns: table => new
                {
                    busno = table.Column<double>(nullable: false),
                    drivername = table.Column<string>(nullable: true),
                    contactno = table.Column<string>(nullable: true),
                    route = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportationinfos", x => x.busno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transportationinfos");

            migrationBuilder.RenameColumn(
                name: "parentname",
                table: "StudentsInfos",
                newName: "parent");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "StaffInfos",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "StaffInfos",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FacultyName",
                table: "StaffInfos",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FacultyAddress",
                table: "StaffInfos",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "Parentsinfos",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Parentsinfos",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "parentname",
                table: "Parentsinfos",
                newName: "parent");
        }
    }
}
