using Microsoft.EntityFrameworkCore.Migrations;

namespace VogCodeChallenge.API.Migrations
{
    public partial class initio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartmentId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    JobTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Address = table.Column<string>(unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Sales" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Marketing" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { 1, "2267 Water Street, Kitchener, ON N2H 5A5", 1, "Arthur", "Sales Manager", "Parker" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { 3, "", 1, "Joe", "Associate manager", "Lukens" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { 2, "1884 Jasper Ave, Edmonton, AB T5J 3N6", 2, "Steve", "Administrative assistant", "Padilla" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { 4, "154 Carling Avenue, Ottawa, ON K1Z 7B5", 2, "Richard", "Project Coordinator", "McCormick" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
