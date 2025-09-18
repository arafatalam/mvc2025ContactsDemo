using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc2025ContactsDemo.Migrations
{
    /// <inheritdoc />
    public partial class addedAddressFieldForContactModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Municipality",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetAdress",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Municipality",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "StreetAdress",
                table: "Contacts");
        }
    }
}
