using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class usertableupdate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Size_SizeId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizzas_PizzaId",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topping",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crust",
                table: "Crust");

            migrationBuilder.RenameTable(
                name: "Topping",
                newName: "ToppingsTable");

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "Crust",
                newName: "Crusts");

            migrationBuilder.RenameIndex(
                name: "IX_Topping_PizzaId",
                table: "ToppingsTable",
                newName: "IX_ToppingsTable_PizzaId");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ToppingsTable",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Crusts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToppingsTable",
                table: "ToppingsTable",
                column: "ToppingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts",
                column: "CrustId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crusts_CrustId",
                table: "Pizzas",
                column: "CrustId",
                principalTable: "Crusts",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeId",
                table: "Pizzas",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingsTable_Pizzas_PizzaId",
                table: "ToppingsTable",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_CrustId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_ToppingsTable_Pizzas_PizzaId",
                table: "ToppingsTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToppingsTable",
                table: "ToppingsTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts");

            migrationBuilder.RenameTable(
                name: "ToppingsTable",
                newName: "Topping");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "Crusts",
                newName: "Crust");

            migrationBuilder.RenameIndex(
                name: "IX_ToppingsTable_PizzaId",
                table: "Topping",
                newName: "IX_Topping_PizzaId");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Locations",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Locations",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Locations",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topping",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Crust",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topping",
                table: "Topping",
                column: "ToppingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crust",
                table: "Crust",
                column: "CrustId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustId",
                table: "Pizzas",
                column: "CrustId",
                principalTable: "Crust",
                principalColumn: "CrustId",
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
    }
}
