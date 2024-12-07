using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCinemaIdFromActorMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Cinemas_cinemaId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Producers_producerId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_cinemaId",
                table: "Actors_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_producerId",
                table: "Actors_Movies");

            migrationBuilder.DropColumn(
                name: "cinemaId",
                table: "Actors_Movies");

            migrationBuilder.DropColumn(
                name: "producerId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "producerId");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Movies",
                newName: "cinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                newName: "IX_Movies_producerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                newName: "IX_Movies_cinemaId");

            migrationBuilder.AlterColumn<int>(
                name: "producerId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cinemaId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_cinemaId",
                table: "Movies",
                column: "cinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_producerId",
                table: "Movies",
                column: "producerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_cinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_producerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "producerId",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "cinemaId",
                table: "Movies",
                newName: "CinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_producerId",
                table: "Movies",
                newName: "IX_Movies_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_cinemaId",
                table: "Movies",
                newName: "IX_Movies_CinemaId");

            migrationBuilder.AlterColumn<int>(
                name: "ProducerId",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "cinemaId",
                table: "Actors_Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "producerId",
                table: "Actors_Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_cinemaId",
                table: "Actors_Movies",
                column: "cinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_producerId",
                table: "Actors_Movies",
                column: "producerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Cinemas_cinemaId",
                table: "Actors_Movies",
                column: "cinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Producers_producerId",
                table: "Actors_Movies",
                column: "producerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id");
        }
    }
}
