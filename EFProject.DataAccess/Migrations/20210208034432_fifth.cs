using Microsoft.EntityFrameworkCore.Migrations;

namespace EFProject.DataAccess.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DepartMents_DepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartMents",
                table: "DepartMents");

            migrationBuilder.RenameTable(
                name: "DepartMents",
                newName: "Departments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "DepartMents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartMents",
                table: "DepartMents",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DepartMents_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "DepartMents",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
