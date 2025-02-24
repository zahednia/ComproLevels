using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Workkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessLevels");

            migrationBuilder.DropTable(
                name: "ComproUsers");

            migrationBuilder.CreateTable(
                name: "GeneralUserAccessLevel",
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
                    table.PrimaryKey("PK_GeneralUserAccessLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    FullNameE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralUserAccessLevel");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "AccessLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessDelete = table.Column<bool>(type: "bit", nullable: false),
                    AccessEdit = table.Column<bool>(type: "bit", nullable: false),
                    AccessFirstConfirm = table.Column<bool>(type: "bit", nullable: false),
                    AccessLevel_Id = table.Column<int>(type: "int", nullable: false),
                    AccessNew = table.Column<bool>(type: "bit", nullable: false),
                    AccessPrint = table.Column<bool>(type: "bit", nullable: false),
                    AccessSecondConfirm = table.Column<bool>(type: "bit", nullable: false),
                    AccessView = table.Column<bool>(type: "bit", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
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
                    Code = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComproUsers", x => x.Id);
                });
        }
    }
}
