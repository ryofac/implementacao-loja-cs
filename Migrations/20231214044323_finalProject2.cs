using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ryanAps.Migrations
{
    public partial class finalProject2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Banco",
                table: "TipoPagamento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bandeira",
                table: "TipoPagamento",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TipoPagamento",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NumeroDoCartao",
                table: "TipoPagamento",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NumeroDoCheque",
                table: "TipoPagamento",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Banco",
                table: "TipoPagamento");

            migrationBuilder.DropColumn(
                name: "Bandeira",
                table: "TipoPagamento");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TipoPagamento");

            migrationBuilder.DropColumn(
                name: "NumeroDoCartao",
                table: "TipoPagamento");

            migrationBuilder.DropColumn(
                name: "NumeroDoCheque",
                table: "TipoPagamento");
        }
    }
}
