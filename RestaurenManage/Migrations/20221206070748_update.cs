using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurenManage.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foodid",
                table: "CartModel");

            migrationBuilder.AddColumn<string>(
                name: "foodname",
                table: "CartModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foodname",
                table: "CartModel");

            migrationBuilder.AddColumn<int>(
                name: "foodid",
                table: "CartModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
