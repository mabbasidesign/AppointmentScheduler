using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentScheduler.Migrations
{
    public partial class currectspelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duriation",
                table: "Appointments",
                newName: "Duration");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Appointments",
                newName: "Duriation");
        }
    }
}
