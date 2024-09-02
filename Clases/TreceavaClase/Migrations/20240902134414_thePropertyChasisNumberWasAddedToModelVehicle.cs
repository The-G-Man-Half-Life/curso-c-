using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreceavaClase.Migrations
{
    /// <inheritdoc />
    public partial class thePropertyChasisNumberWasAddedToModelVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChasisNumber",
                table: "Vehicles",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChasisNumber",
                table: "Vehicles");
        }
    }
}
