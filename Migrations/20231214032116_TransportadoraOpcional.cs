using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ryanAps.Migrations
{
    public partial class TransportadoraOpcional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda");

            migrationBuilder.AlterColumn<int>(
                name: "TransportadoraId",
                table: "NotaDeVenda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda",
                column: "TransportadoraId",
                principalTable: "Transportadora",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda");

            migrationBuilder.AlterColumn<int>(
                name: "TransportadoraId",
                table: "NotaDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda",
                column: "TransportadoraId",
                principalTable: "Transportadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
