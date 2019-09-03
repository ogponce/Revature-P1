using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class usertableupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Address_AddressId",
                table: "Location");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Location_AddressId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Location");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Location",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Location");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Location",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    StateProvince = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_AddressId",
                table: "Location",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Address_AddressId",
                table: "Location",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
