using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViewEvents.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "speakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: false),
                    ImgURL = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Local = table.Column<string>(type: "TEXT", nullable: false),
                    EventDate = table.Column<string>(type: "TEXT", nullable: false),
                    Theme = table.Column<string>(type: "TEXT", nullable: false),
                    PeopleAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: false),
                    SpeakerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_events_speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "eventspeakers",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    SpeakerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventspeakers", x => new { x.EventId, x.SpeakerId });
                    table.ForeignKey(
                        name: "FK_eventspeakers_events_EventId",
                        column: x => x.EventId,
                        principalTable: "events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_eventspeakers_speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false),
                    DateStart = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lots_events_EventId",
                        column: x => x.EventId,
                        principalTable: "events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "socialnetworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    SpeakerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialnetworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_socialnetworks_events_EventId",
                        column: x => x.EventId,
                        principalTable: "events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_socialnetworks_speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "speakers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_events_SpeakerId",
                table: "events",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_eventspeakers_SpeakerId",
                table: "eventspeakers",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_lots_EventId",
                table: "lots",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_socialnetworks_EventId",
                table: "socialnetworks",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_socialnetworks_SpeakerId",
                table: "socialnetworks",
                column: "SpeakerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eventspeakers");

            migrationBuilder.DropTable(
                name: "lots");

            migrationBuilder.DropTable(
                name: "socialnetworks");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "speakers");
        }
    }
}
