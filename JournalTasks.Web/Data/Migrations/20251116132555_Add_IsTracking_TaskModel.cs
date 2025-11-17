using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JournalTasks.Web.Migrations
{
    /// <inheritdoc />
    public partial class Add_IsTracking_TaskModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskModels_AspNetUsers_UserId",
                table: "TaskModels");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TaskModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsTracking",
                table: "TaskModels",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskModels_AspNetUsers_UserId",
                table: "TaskModels",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskModels_AspNetUsers_UserId",
                table: "TaskModels");

            migrationBuilder.DropColumn(
                name: "IsTracking",
                table: "TaskModels");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TaskModels",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskModels_AspNetUsers_UserId",
                table: "TaskModels",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
