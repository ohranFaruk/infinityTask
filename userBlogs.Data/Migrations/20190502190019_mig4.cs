using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace userBlogs.Data.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_admins_AdminId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Users",
                newName: "KorisnickoNalogId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AdminId",
                table: "Users",
                newName: "IX_Users_KorisnickoNalogId");

            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "korisnickoNalogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnickoNalogs", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_korisnickoNalogs_KorisnickoNalogId",
                table: "Users",
                column: "KorisnickoNalogId",
                principalTable: "korisnickoNalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_korisnickoNalogs_KorisnickoNalogId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "korisnickoNalogs");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "KorisnickoNalogId",
                table: "Users",
                newName: "AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_KorisnickoNalogId",
                table: "Users",
                newName: "IX_Users_AdminId");

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    password = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_admins_AdminId",
                table: "Users",
                column: "AdminId",
                principalTable: "admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
