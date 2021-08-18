using Microsoft.EntityFrameworkCore.Migrations;

namespace DataManagement.Migrations
{
    public partial class StudentDbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentTbl",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    StudentSurname = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    StudentNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTbl", x => x.StudentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTbl");
        }
    }
}
