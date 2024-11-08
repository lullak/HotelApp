using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValueToIsCancelled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
            name: "IsCancelled",
            table: "Bookings",
            nullable: false,
            defaultValue: false,
            oldClrType: typeof(bool),
            oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
            name: "IsCancelled",
            table: "Bookings",
            nullable: true,
            oldClrType: typeof(bool),
            oldDefaultValue: false);
        }
    }
}
