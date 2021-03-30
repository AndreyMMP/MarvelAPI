using Microsoft.EntityFrameworkCore.Migrations;

namespace MarvelAPI.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Copyright = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttributionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttributionHTML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarvelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterInformation_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<int>(type: "int", nullable: false),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comics_CharacterInformation_CharacterInformationId",
                        column: x => x.CharacterInformationId,
                        principalTable: "CharacterInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<int>(type: "int", nullable: false),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_CharacterInformation_CharacterInformationId",
                        column: x => x.CharacterInformationId,
                        principalTable: "CharacterInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<int>(type: "int", nullable: false),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_CharacterInformation_CharacterInformationId",
                        column: x => x.CharacterInformationId,
                        principalTable: "CharacterInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<int>(type: "int", nullable: false),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stories_CharacterInformation_CharacterInformationId",
                        column: x => x.CharacterInformationId,
                        principalTable: "CharacterInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Thumbnail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thumbnail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thumbnail_CharacterInformation_CharacterInformationId",
                        column: x => x.CharacterInformationId,
                        principalTable: "CharacterInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Url",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Url", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Url_CharacterInformation_CharacterInformationId",
                        column: x => x.CharacterInformationId,
                        principalTable: "CharacterInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComicsItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicsId = table.Column<int>(type: "int", nullable: false),
                    ResourceURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicsItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComicsItem_Comics_ComicsId",
                        column: x => x.ComicsId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventsItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    ResourceURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventsItem_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeriesItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesId = table.Column<int>(type: "int", nullable: false),
                    ResourceURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesItem_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoriesItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoriesId = table.Column<int>(type: "int", nullable: false),
                    ResourceURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoriesItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoriesItem_Stories_StoriesId",
                        column: x => x.StoriesId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "AttributionHTML", "AttributionText", "Copyright", "Etag" },
                values: new object[] { 1, "<a href=\"http://marvel.com\">Data provided by Marvel. © 2021 MARVEL</a>", "Data provided by Marvel. © 2021 MARVEL", "© 2021 MARVEL", "20cf4cd43cc9cd35833392e0964888958f576824" });

            migrationBuilder.InsertData(
                table: "CharacterInformation",
                columns: new[] { "Id", "CharacterId", "Description", "MarvelId", "Modified", "Name", "ResourceURI" },
                values: new object[] { 1, 1, "Rick Jones has been Hulk's best bud since day one, but now he's more than a friend...he's a teammate! Transformed by a Gamma energy explosion, A-Bomb's thick, armored skin is just as strong and powerful as it is blue. And when he curls into action, he uses it like a giant bowling ball of destruction!", 1017100, "30/03/2021 17:12:16", "A-Bomb (HAS)", "http://gateway.marvel.com/v1/public/characters/1017100" });

            migrationBuilder.InsertData(
                table: "Comics",
                columns: new[] { "Id", "Available", "CharacterInformationId", "CollectionURI" },
                values: new object[] { 1, 3, 1, "http://gateway.marvel.com/v1/public/characters/1017100/comics" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Available", "CharacterInformationId", "CollectionURI" },
                values: new object[] { 1, 0, 1, "http://gateway.marvel.com/v1/public/characters/1017100/events" });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Available", "CharacterInformationId", "CollectionURI" },
                values: new object[] { 1, 2, 1, "http://gateway.marvel.com/v1/public/characters/1017100/series" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "Available", "CharacterInformationId", "CollectionURI" },
                values: new object[] { 1, 2, 1, "http://gateway.marvel.com/v1/public/characters/1017100/stories" });

            migrationBuilder.InsertData(
                table: "Thumbnail",
                columns: new[] { "Id", "CharacterInformationId", "Extension", "Path" },
                values: new object[] { 1, 1, "jpg", "http://i.annihil.us/u/prod/marvel/i/mg/3/20/5232158de5b16" });

            migrationBuilder.InsertData(
                table: "Url",
                columns: new[] { "Id", "CharacterInformationId", "Type", "Uri" },
                values: new object[,]
                {
                    { 1, 1, "detail", "http://marvel.com/characters/76/a-bomb?utm_campaign=apiRef&utm_source=d56c9ed938d7d397eb1933d4070e8cda" },
                    { 2, 1, "comiclink", "http://marvel.com/comics/characters/1017100/a-bomb_has?utm_campaign=apiRef&utm_source=d56c9ed938d7d397eb1933d4070e8cda" }
                });

            migrationBuilder.InsertData(
                table: "ComicsItem",
                columns: new[] { "Id", "ComicsId", "Name", "ResourceURI" },
                values: new object[,]
                {
                    { 1, 1, "Hulk (2008) #53", "http://gateway.marvel.com/v1/public/comics/40632" },
                    { 2, 1, "Hulk (2008) #54", "http://gateway.marvel.com/v1/public/comics/40630" },
                    { 3, 1, "Hulk (2008) #55", "http://gateway.marvel.com/v1/public/comics/40628" }
                });

            migrationBuilder.InsertData(
                table: "SeriesItem",
                columns: new[] { "Id", "Name", "ResourceURI", "SeriesId" },
                values: new object[,]
                {
                    { 1, "FREE COMIC BOOK DAY 2013 1 (2013)", "http://gateway.marvel.com/v1/public/series/17765", 1 },
                    { 2, "Hulk (2008 - 2012)", "http://gateway.marvel.com/v1/public/series/3374", 1 }
                });

            migrationBuilder.InsertData(
                table: "StoriesItem",
                columns: new[] { "Id", "Name", "ResourceURI", "StoriesId", "Type" },
                values: new object[,]
                {
                    { 1, "Hulk (2008) #55", "http://gateway.marvel.com/v1/public/stories/92078", 1, "cover" },
                    { 2, "Interior #92079", "http://gateway.marvel.com/v1/public/stories/92079", 1, "interiorStory" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInformation_CharacterId",
                table: "CharacterInformation",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comics_CharacterInformationId",
                table: "Comics",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComicsItem_ComicsId",
                table: "ComicsItem",
                column: "ComicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CharacterInformationId",
                table: "Events",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventsItem_EventsId",
                table: "EventsItem",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CharacterInformationId",
                table: "Series",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesItem_SeriesId",
                table: "SeriesItem",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Stories_CharacterInformationId",
                table: "Stories",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoriesItem_StoriesId",
                table: "StoriesItem",
                column: "StoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Thumbnail_CharacterInformationId",
                table: "Thumbnail",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Url_CharacterInformationId",
                table: "Url",
                column: "CharacterInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComicsItem");

            migrationBuilder.DropTable(
                name: "EventsItem");

            migrationBuilder.DropTable(
                name: "SeriesItem");

            migrationBuilder.DropTable(
                name: "StoriesItem");

            migrationBuilder.DropTable(
                name: "Thumbnail");

            migrationBuilder.DropTable(
                name: "Url");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropTable(
                name: "CharacterInformation");

            migrationBuilder.DropTable(
                name: "Character");
        }
    }
}
