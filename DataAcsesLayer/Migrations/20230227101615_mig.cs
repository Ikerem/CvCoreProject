using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcsesLayer.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img1",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img2",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img3",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img4",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Values",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img1",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Img2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Img3",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Img4",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Values",
                table: "Portfolios");
        }
    }
}
