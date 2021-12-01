using Microsoft.EntityFrameworkCore.Migrations;

namespace GestiónDeProyectos.Migrations
{
    public partial class TareaD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Duracion",
                table: "Tarea",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracion",
                table: "Tarea");
        }
    }
}
