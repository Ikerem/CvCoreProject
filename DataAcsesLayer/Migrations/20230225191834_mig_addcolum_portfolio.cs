using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcsesLayer.Migrations
{
    public partial class mig_addcolum_portfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl2",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjecUrl",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ProjecUrl",
                table: "Portfolios");
        }
    }
}
