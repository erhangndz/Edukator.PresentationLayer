using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccessLayer.Migrations
{
    public partial class mig_about_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Abouts",
                newName: "Title2");

            migrationBuilder.RenameColumn(
                name: "ImageText",
                table: "Abouts",
                newName: "Title1");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Abouts",
                newName: "ImageText4");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Abouts",
                newName: "ImageText3");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageText1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageText2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "ImageText1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "ImageText2",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "Abouts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Title1",
                table: "Abouts",
                newName: "ImageText");

            migrationBuilder.RenameColumn(
                name: "ImageText4",
                table: "Abouts",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageText3",
                table: "Abouts",
                newName: "Description");
        }
    }
}
