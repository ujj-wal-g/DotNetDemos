using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConventionDemo.Migrations
{
    public partial class AddedEmpTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "employeeAddreses",
                columns: table => new
                {
                    EmpAddressId = table.Column<int>(type: "int", nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpPinCode = table.Column<int>(type: "int", nullable: false),
                    EmpState = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeAddreses", x => x.EmpAddressId);
                    table.ForeignKey(
                        name: "FK_employeeAddreses_employees_EmpAddressId",
                        column: x => x.EmpAddressId,
                        principalTable: "employees",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeAddreses");

            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
