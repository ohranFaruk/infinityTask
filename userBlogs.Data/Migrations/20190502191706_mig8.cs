using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace userBlogs.Data.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "korisnickoNalogs");

            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KorisnickiNalog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_KorisnickiNalogId",
                table: "Users",
                column: "KorisnickiNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_KorisnickiNalog_KorisnickiNalogId",
                table: "Users",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_KorisnickiNalog_KorisnickiNalogId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "KorisnickiNalog");

            migrationBuilder.DropIndex(
                name: "IX_Users_KorisnickiNalogId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "korisnickoNalogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    password = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnickoNalogs", x => x.Id);
                });
        }
    }
}
