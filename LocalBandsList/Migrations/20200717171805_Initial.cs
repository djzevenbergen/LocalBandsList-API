using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessLookup.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    BandId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    Bio = table.Column<string>(maxLength: 300, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    YearFormed = table.Column<string>(nullable: true),
                    VideoLink = table.Column<string>(nullable: true),
                    MusicLink = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Together = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Gigging = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.BandId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "Bio", "Email", "Genre", "Gigging", "MusicLink", "Name", "Together", "UserId", "VideoLink", "YearFormed", "ZipCode" },
                values: new object[,]
                {
                    { 10, "Just me, bein' Deej.", null, "indie", false, "https://soundcloud.com/yourfrienddeej/i-fell-in-love-with-a-postcard", "Your Friend Deej", true, 1, "https://www.youtube.com/watch?v=zRmL4tVbs6Y", "2015", "98020" },
                    { 9, "Jammy Jr. is an odd blend of chiptunes and whispery-soul", null, "synth pop", false, "https://soundcloud.com/jammyjr/5-computer-time-house", "Jammy Jr.", true, 1, "https://vimeo.com/286650646", "2017", "98020" },
                    { 8, "Hopeful Mac Demarco-lookin asses trying to make something fun", null, "indie pop", false, "", "Dad Friendly", true, 1, "", "2019", "98109" },
                    { 7, "A group of jabronies that liked to rock", null, "rock", false, "https://soundcloud.com/wearecon/allison", "CON", true, 1, "", "2013", null },
                    { 6, "A well-oiled rock machine, pumping out tunes for early-morning smoke sessions", null, "psychedelic rock", true, "https://soundcloud.com/smoothrichard/lintfire", "Smooth Richard", true, 1, "", "2017", "98125" },
                    { 5, "Vibe out with this understated electronic duo", null, "IDM", true, "https://soundcloud.com/crystalssquad/hover-board", "bad gravity", true, 1, "", "2018", "98109" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "Token", "Username" },
                values: new object[] { 1, "David", "Zevenbergen", "test", null, "DJTest" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bands");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
