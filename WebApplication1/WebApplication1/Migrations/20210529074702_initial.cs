using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    placeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    area = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.placeId);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    addressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    longitude = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    latitude = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    placeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.addressId);
                    table.ForeignKey(
                        name: "FK_Address_Place_placeId",
                        column: x => x.placeId,
                        principalTable: "Place",
                        principalColumn: "placeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_placeId",
                table: "Address",
                column: "placeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Place");
        }
    }
}
