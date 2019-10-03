using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class added_staffinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pincode",
                table: "SchoolInfos",
                newName: "PinCode");

            migrationBuilder.CreateTable(
                name: "StaffInfos",
                columns: table => new
                {
                    FacultyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 18, nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    subject = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffInfos", x => x.FacultyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffInfos");

            migrationBuilder.RenameColumn(
                name: "PinCode",
                table: "SchoolInfos",
                newName: "Pincode");
        }
    }
}
