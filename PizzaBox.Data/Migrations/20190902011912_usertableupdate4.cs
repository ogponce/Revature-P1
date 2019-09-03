using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class usertableupdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_LocationId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Order",
                newName: "OrderLocationLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_LocationId",
                table: "Order",
                newName: "IX_Order_OrderLocationLocationId");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Accounts_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_LocationId",
                table: "Accounts",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_OrderLocationLocationId",
                table: "Order",
                column: "OrderLocationLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_OrderLocationLocationId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.RenameColumn(
                name: "OrderLocationLocationId",
                table: "Order",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderLocationLocationId",
                table: "Order",
                newName: "IX_Order_LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_LocationId",
                table: "Order",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
