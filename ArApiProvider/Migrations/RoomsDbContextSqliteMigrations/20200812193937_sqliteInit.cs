using Microsoft.EntityFrameworkCore.Migrations;

namespace ArApiProvider.Migrations.RoomsDbContextSqliteMigrations
{
    public partial class sqliteInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WallBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PositionX = table.Column<double>(nullable: false),
                    PositionY = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Rotation = table.Column<int>(nullable: false),
                    RoomPlanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WallBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WallBlocks_RoomPlans_RoomPlanId",
                        column: x => x.RoomPlanId,
                        principalTable: "RoomPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WallBlocks_RoomPlanId",
                table: "WallBlocks",
                column: "RoomPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WallBlocks");

            migrationBuilder.DropTable(
                name: "RoomPlans");
        }
    }
}
