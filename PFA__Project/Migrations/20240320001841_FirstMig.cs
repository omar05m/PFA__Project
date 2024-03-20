using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFA__Project.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IdCategorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCategorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionCategorie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IdCategorie);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    IdUtilisateur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateInscription = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.IdUtilisateur);
                });

            migrationBuilder.CreateTable(
                name: "Artisans",
                columns: table => new
                {
                    IdArtisan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbrAnneeExperience = table.Column<int>(type: "int", nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumTele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixDeService = table.Column<float>(type: "real", nullable: false),
                    ImageDeCarteID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUtilisateur = table.Column<int>(type: "int", nullable: false),
                    CategorieIdCategorie = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artisans", x => x.IdArtisan);
                    table.ForeignKey(
                        name: "FK_Artisans_Categories_CategorieIdCategorie",
                        column: x => x.CategorieIdCategorie,
                        principalTable: "Categories",
                        principalColumn: "IdCategorie");
                    table.ForeignKey(
                        name: "FK_Artisans_Utilisateurs_IdUtilisateur",
                        column: x => x.IdUtilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "IdUtilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                    table.ForeignKey(
                        name: "FK_Clients_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "IdUtilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNotification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "IdUtilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtisansCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtisanId = table.Column<int>(type: "int", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtisansCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtisansCategories_Artisans_ArtisanId",
                        column: x => x.ArtisanId,
                        principalTable: "Artisans",
                        principalColumn: "IdArtisan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtisansCategories_Categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categories",
                        principalColumn: "IdCategorie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RendezVous",
                columns: table => new
                {
                    IdRendezVous = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRendezVous = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TauxService = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtisanId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RendezVous", x => x.IdRendezVous);
                    table.ForeignKey(
                        name: "FK_RendezVous_Artisans_ArtisanId",
                        column: x => x.ArtisanId,
                        principalTable: "Artisans",
                        principalColumn: "IdArtisan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RendezVous_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
    name: "IX_Artisans_IdUtilisateur",
    table: "Artisans",
    column: "IdUtilisateur",
    unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtisansCategories_ArtisanId",
                table: "ArtisansCategories",
                column: "ArtisanId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtisansCategories_CategorieId",
                table: "ArtisansCategories",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UtilisateurId",
                table: "Clients",
                column: "UtilisateurId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UtilisateurId",
                table: "Notifications",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_RendezVous_ArtisanId",
                table: "RendezVous",
                column: "ArtisanId");

            migrationBuilder.CreateIndex(
                name: "IX_RendezVous_ClientId",
                table: "RendezVous",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtisansCategories");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "RendezVous");

            migrationBuilder.DropTable(
                name: "Artisans");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Utilisateurs");
        }
    }
}

