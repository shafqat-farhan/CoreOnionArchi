using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COA.Models.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { 1, "shafqat" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { 2, "farhan" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[] { 1, "My first post content", new DateTime(2019, 10, 10, 7, 23, 50, 596, DateTimeKind.Local).AddTicks(1335), "My first post", 1 });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[] { 2, "My second post content", new DateTime(2019, 10, 10, 7, 23, 50, 600, DateTimeKind.Local).AddTicks(8194), "My second post", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
