using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConventionDemo.Migrations
{
    public partial class AddedAspirantsCoursesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeAddress",
                table: "employeeAddreses",
                newName: "EmpAddress");

            migrationBuilder.CreateTable(
                name: "aspirants",
                columns: table => new
                {
                    AspId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AspName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspirants", x => x.AspId);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "aspirantscourses",
                columns: table => new
                {
                    AspId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspirantscourses", x => new { x.AspId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_aspirantscourses_aspirants_AspId",
                        column: x => x.AspId,
                        principalTable: "aspirants",
                        principalColumn: "AspId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aspirantscourses_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aspirantscourses_CourseId",
                table: "aspirantscourses",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aspirantscourses");

            migrationBuilder.DropTable(
                name: "aspirants");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.RenameColumn(
                name: "EmpAddress",
                table: "employeeAddreses",
                newName: "EmployeeAddress");
        }
    }
}
