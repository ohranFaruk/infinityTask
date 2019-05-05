using Microsoft.EntityFrameworkCore.Migrations;

namespace userBlogs.Data.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_korisnickoNalogs_KorisnickoNalogId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_KorisnickoNalogId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "KorisnickoNalogId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KorisnickoNalogId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_KorisnickoNalogId",
                table: "Users",
                column: "KorisnickoNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_korisnickoNalogs_KorisnickoNalogId",
                table: "Users",
                column: "KorisnickoNalogId",
                principalTable: "korisnickoNalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
