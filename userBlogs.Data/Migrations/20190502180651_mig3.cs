using Microsoft.EntityFrameworkCore.Migrations;

namespace userBlogs.Data.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "admins",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "username",
                table: "admins",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
