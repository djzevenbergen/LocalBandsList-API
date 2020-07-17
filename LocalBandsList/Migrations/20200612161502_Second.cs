using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBandsList.Migrations
{
  public partial class Second : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AlterColumn<string>(
          name: "Type",
          table: "Bands",
          nullable: false,
          oldClrType: typeof(string),
          oldNullable: true);

      migrationBuilder.AlterColumn<string>(
          name: "Name",
          table: "Bands",
          maxLength: 50,
          nullable: false,
          oldClrType: typeof(string),
          oldNullable: true);

      migrationBuilder.AlterColumn<string>(
          name: "Description",
          table: "Bands",
          maxLength: 300,
          nullable: true,
          oldClrType: typeof(string),
          oldNullable: true);

      migrationBuilder.AddColumn<int>(
          name: "UserId",
          table: "Bands",
          nullable: false,
          defaultValue: 0);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "UserId",
          table: "Bands");

      migrationBuilder.AlterColumn<string>(
          name: "Type",
          table: "Bands",
          nullable: true,
          oldClrType: typeof(string));

      migrationBuilder.AlterColumn<string>(
          name: "Name",
          table: "Bands",
          nullable: true,
          oldClrType: typeof(string),
          oldMaxLength: 50);

      migrationBuilder.AlterColumn<string>(
          name: "Description",
          table: "Bands",
          nullable: true,
          oldClrType: typeof(string),
          oldMaxLength: 300,
          oldNullable: true);
    }
  }
}
