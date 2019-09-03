using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class usertableupdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Location_LocationId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Location_LocationId1",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_OrderLocationLocationId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Crust_CrustId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Location_LocationId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Order_OrderId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Size_SizeId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizza_PizzaId",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Pizza",
                newName: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_SizeId",
                table: "Pizzas",
                newName: "IX_Pizzas_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_OrderId",
                table: "Pizzas",
                newName: "IX_Pizzas_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_LocationId",
                table: "Pizzas",
                newName: "IX_Pizzas_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_CrustId",
                table: "Pizzas",
                newName: "IX_Pizzas_CrustId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_LocationId1",
                table: "Locations",
                newName: "IX_Locations_LocationId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "PizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Locations_LocationId",
                table: "Accounts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Locations_LocationId1",
                table: "Locations",
                column: "LocationId1",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Locations_OrderLocationLocationId",
                table: "Order",
                column: "OrderLocationLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustId",
                table: "Pizzas",
                column: "CrustId",
                principalTable: "Crust",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Locations_LocationId",
                table: "Pizzas",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Order_OrderId",
                table: "Pizzas",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Size_SizeId",
                table: "Pizzas",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_Pizzas_PizzaId",
                table: "Topping",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Locations_LocationId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Locations_LocationId1",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Locations_OrderLocationLocationId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Locations_LocationId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Order_OrderId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Size_SizeId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizzas_PizzaId",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "Pizza");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_SizeId",
                table: "Pizza",
                newName: "IX_Pizza_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_OrderId",
                table: "Pizza",
                newName: "IX_Pizza_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_LocationId",
                table: "Pizza",
                newName: "IX_Pizza_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_CrustId",
                table: "Pizza",
                newName: "IX_Pizza_CrustId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_LocationId1",
                table: "Location",
                newName: "IX_Location_LocationId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza",
                column: "PizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Location_LocationId",
                table: "Accounts",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Location_LocationId1",
                table: "Location",
                column: "LocationId1",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_OrderLocationLocationId",
                table: "Order",
                column: "OrderLocationLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Crust_CrustId",
                table: "Pizza",
                column: "CrustId",
                principalTable: "Crust",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Location_LocationId",
                table: "Pizza",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Order_OrderId",
                table: "Pizza",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Size_SizeId",
                table: "Pizza",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_Pizza_PizzaId",
                table: "Topping",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
