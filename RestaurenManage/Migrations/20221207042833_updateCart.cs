using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurenManage.Migrations
{
    /// <inheritdoc />
    public partial class updateCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tableid",
                table: "CartModel");

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "CartModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableName",
                table: "CartModel");

            migrationBuilder.AddColumn<int>(
                name: "tableid",
                table: "CartModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
