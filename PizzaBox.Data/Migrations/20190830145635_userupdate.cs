using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class userupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Users_UserId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Account_AccountId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Location_LatestLocationId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Name_NameId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Location_checklocationLocationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropIndex(
                name: "IX_Users_AccountId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LatestLocationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NameId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_checklocationLocationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Location_UserId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LatestLocationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "checklocationLocationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Location");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LatestLocationId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "checklocationLocationId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Location",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    NameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First = table.Column<string>(nullable: true),
                    Last = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.NameId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountId",
                table: "Users",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LatestLocationId",
                table: "Users",
                column: "LatestLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NameId",
                table: "Users",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_checklocationLocationId",
                table: "Users",
                column: "checklocationLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_UserId",
                table: "Location",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Users_UserId",
                table: "Location",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Account_AccountId",
                table: "Users",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Address_AddressId",
                table: "Users",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Location_LatestLocationId",
                table: "Users",
                column: "LatestLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Name_NameId",
                table: "Users",
                column: "NameId",
                principalTable: "Name",
                principalColumn: "NameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Location_checklocationLocationId",
                table: "Users",
                column: "checklocationLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
