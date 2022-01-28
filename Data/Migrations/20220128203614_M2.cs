using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab04.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provinces_ProvinceCode1",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_ProvinceCode1",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ProvinceCode1",
                table: "Cities");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceCode",
                table: "Cities",
                column: "ProvinceCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provinces_ProvinceCode",
                table: "Cities",
                column: "ProvinceCode",
                principalTable: "Provinces",
                principalColumn: "ProvinceCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provinces_ProvinceCode",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_ProvinceCode",
                table: "Cities");

            migrationBuilder.AddColumn<string>(
                name: "ProvinceCode1",
                table: "Cities",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceCode1",
                table: "Cities",
                column: "ProvinceCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provinces_ProvinceCode1",
                table: "Cities",
                column: "ProvinceCode1",
                principalTable: "Provinces",
                principalColumn: "ProvinceCode");
        }
    }
}
