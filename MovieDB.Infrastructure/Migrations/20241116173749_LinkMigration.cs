using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LinkMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Episodes_EpisodeId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_PersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Seasons_SeasonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Episodes_EpisodeId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Media_MediaId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_People_PersonId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Seasons_SeasonId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_People_PersonId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_PersonId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ImdbRating",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "ImdbVotes",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Metascore",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "RottenTomatoes",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "VoteCount",
                table: "Media");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Reviews",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Filming",
                table: "Seasons",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plot",
                table: "Seasons",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediaId1",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Filming",
                table: "MediaTranslation",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plot",
                table: "MediaTranslation",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Filming",
                table: "Media",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plot",
                table: "Media",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Filming",
                table: "Episodes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plot",
                table: "Episodes",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MediaId1",
                table: "Reviews",
                column: "MediaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Episodes_EpisodeId",
                table: "Comments",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_PersonId",
                table: "Comments",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Seasons_SeasonId",
                table: "Comments",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Episodes_EpisodeId",
                table: "Likes",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Media_MediaId",
                table: "Likes",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_People_PersonId",
                table: "Likes",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Seasons_SeasonId",
                table: "Likes",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Media_MediaId1",
                table: "Reviews",
                column: "MediaId1",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Episodes_EpisodeId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_PersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Seasons_SeasonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Episodes_EpisodeId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Media_MediaId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_People_PersonId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Seasons_SeasonId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Media_MediaId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_MediaId1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Filming",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "Plot",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "MediaId1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Filming",
                table: "MediaTranslation");

            migrationBuilder.DropColumn(
                name: "Plot",
                table: "MediaTranslation");

            migrationBuilder.DropColumn(
                name: "Filming",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Plot",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Filming",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "Plot",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Reviews",
                newName: "PersonId");

            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "Reviews",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Reviews",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ImdbRating",
                table: "Media",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImdbVotes",
                table: "Media",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Metascore",
                table: "Media",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RottenTomatoes",
                table: "Media",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoteCount",
                table: "Media",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PersonId",
                table: "Reviews",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Episodes_EpisodeId",
                table: "Comments",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Media_MediaId",
                table: "Comments",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_PersonId",
                table: "Comments",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Seasons_SeasonId",
                table: "Comments",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Episodes_EpisodeId",
                table: "Likes",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Media_MediaId",
                table: "Likes",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_People_PersonId",
                table: "Likes",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Seasons_SeasonId",
                table: "Likes",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_People_PersonId",
                table: "Reviews",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
