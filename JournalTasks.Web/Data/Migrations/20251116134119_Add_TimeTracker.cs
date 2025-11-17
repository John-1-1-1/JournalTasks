using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JournalTasks.Web.Migrations
{
    /// <inheritdoc />
    public partial class Add_TimeTracker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeltaTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    TaskId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    TaskModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeltaTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeltaTimes_TaskModels_TaskModelId",
                        column: x => x.TaskModelId,
                        principalTable: "TaskModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeltaTimes_TaskModelId",
                table: "DeltaTimes",
                column: "TaskModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeltaTimes");
        }
    }
}
