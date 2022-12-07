using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurenManage.Migrations
{
    /// <inheritdoc />
    public partial class newdbss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tableid = table.Column<int>(type: "int", nullable: false),
                    Tablepos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    foodid = table.Column<int>(type: "int", nullable: false),
                    foodprice = table.Column<int>(type: "int", nullable: false),
                    person = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartModel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartModel");
        }
    }
}
