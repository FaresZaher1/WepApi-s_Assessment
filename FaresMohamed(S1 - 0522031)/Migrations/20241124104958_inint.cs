using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaresMohamed_S1___0522031_.Migrations
{
    /// <inheritdoc />
    public partial class inint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoryModels",
                columns: table => new
                {
                    CategoryModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryModels", x => x.CategoryModelId);
                });

            migrationBuilder.CreateTable(
                name: "cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    placeholder = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nationalityModels",
                columns: table => new
                {
                    NationalityModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationalityModels", x => x.NationalityModelId);
                });

            migrationBuilder.CreateTable(
                name: "movieModels",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<DateOnly>(type: "date", nullable: false),
                    CategoryModelzCategoryModelId = table.Column<int>(type: "int", nullable: false),
                    CinemaModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieModels", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_movieModels_categoryModels_CategoryModelzCategoryModelId",
                        column: x => x.CategoryModelzCategoryModelId,
                        principalTable: "categoryModels",
                        principalColumn: "CategoryModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieModels_cinemas_CinemaModelId",
                        column: x => x.CinemaModelId,
                        principalTable: "cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "directorModels",
                columns: table => new
                {
                    DirectorModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalityModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directorModels", x => x.DirectorModelId);
                    table.ForeignKey(
                        name: "FK_directorModels_nationalityModels_NationalityModelId",
                        column: x => x.NationalityModelId,
                        principalTable: "nationalityModels",
                        principalColumn: "NationalityModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorModelMovieModel",
                columns: table => new
                {
                    directorModelsDirectorModelId = table.Column<int>(type: "int", nullable: false),
                    movieModelsmovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorModelMovieModel", x => new { x.directorModelsDirectorModelId, x.movieModelsmovieId });
                    table.ForeignKey(
                        name: "FK_DirectorModelMovieModel_directorModels_directorModelsDirectorModelId",
                        column: x => x.directorModelsDirectorModelId,
                        principalTable: "directorModels",
                        principalColumn: "DirectorModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorModelMovieModel_movieModels_movieModelsmovieId",
                        column: x => x.movieModelsmovieId,
                        principalTable: "movieModels",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DirectorModelMovieModel_movieModelsmovieId",
                table: "DirectorModelMovieModel",
                column: "movieModelsmovieId");

            migrationBuilder.CreateIndex(
                name: "IX_directorModels_NationalityModelId",
                table: "directorModels",
                column: "NationalityModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieModels_CategoryModelzCategoryModelId",
                table: "movieModels",
                column: "CategoryModelzCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_movieModels_CinemaModelId",
                table: "movieModels",
                column: "CinemaModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectorModelMovieModel");

            migrationBuilder.DropTable(
                name: "directorModels");

            migrationBuilder.DropTable(
                name: "movieModels");

            migrationBuilder.DropTable(
                name: "nationalityModels");

            migrationBuilder.DropTable(
                name: "categoryModels");

            migrationBuilder.DropTable(
                name: "cinemas");
        }
    }
}
