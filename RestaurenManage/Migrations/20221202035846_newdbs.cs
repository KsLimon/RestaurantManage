using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurenManage.Migrations
{
    /// <inheritdoc />
    public partial class newdbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodModel",
                columns: table => new
                {
                    Foodid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foodimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Couantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    avail = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodModel", x => x.Foodid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodModel");
        }
    }
}
