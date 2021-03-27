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
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CharacterData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Offset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Limit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterData_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarvelId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterInformation_CharacterData_CharacterDataId",
                        column: x => x.CharacterDataId,
                        principalTable: "CharacterData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Available = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Returned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false)
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
                    Available = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Returned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false)
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
                    Available = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Returned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false)
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
                    Available = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Returned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterInformationId = table.Column<int>(type: "int", nullable: false)
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
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceURI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesId = table.Column<int>(type: "int", nullable: false),
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    StoriesId = table.Column<int>(type: "int", nullable: false),
                    ComicsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Comics_ComicsId",
                        column: x => x.ComicsId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Stories_StoriesId",
                        column: x => x.StoriesId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterData_CharacterId",
                table: "CharacterData",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInformation_CharacterDataId",
                table: "CharacterInformation",
                column: "CharacterDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Comics_CharacterInformationId",
                table: "Comics",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CharacterInformationId",
                table: "Events",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_ComicsId",
                table: "Item",
                column: "ComicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_EventsId",
                table: "Item",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SeriesId",
                table: "Item",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_StoriesId",
                table: "Item",
                column: "StoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CharacterInformationId",
                table: "Series",
                column: "CharacterInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_CharacterInformationId",
                table: "Stories",
                column: "CharacterInformationId",
                unique: true);

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
                name: "Item");

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
                name: "CharacterData");

            migrationBuilder.DropTable(
                name: "Character");
        }
    }
}
