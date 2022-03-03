using Microsoft.EntityFrameworkCore.Migrations;

namespace TargetInvestimento.API.Data.Migrations
{
    public partial class second_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cadastrado_PlanoVip",
                table: "Cadastro_Pessoas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Oferecer_PlanoVip",
                table: "Cadastro_Pessoas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cadastrado_PlanoVip",
                table: "Cadastro_Pessoas");

            migrationBuilder.DropColumn(
                name: "Oferecer_PlanoVip",
                table: "Cadastro_Pessoas");
        }
    }
}
