﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    AccessLevel_Id = table.Column<int>(type: "int", nullable: false),
                    AccessView = table.Column<bool>(type: "bit", nullable: false),
                    AccessNew = table.Column<bool>(type: "bit", nullable: false),
                    AccessEdit = table.Column<bool>(type: "bit", nullable: false),
                    AccessDelete = table.Column<bool>(type: "bit", nullable: false),
                    AccessFirstConfirm = table.Column<bool>(type: "bit", nullable: false),
                    AccessSecondConfirm = table.Column<bool>(type: "bit", nullable: false),
                    AccessPrint = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComproUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComproUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessLevels");

            migrationBuilder.DropTable(
                name: "ComproUsers");
        }
    }
}
