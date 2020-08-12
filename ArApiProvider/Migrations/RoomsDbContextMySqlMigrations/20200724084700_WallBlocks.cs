using Microsoft.EntityFrameworkCore.Migrations;

namespace ArApiProvider.Migrations.RoomsDbContextMySqlMigrations
{
    public partial class WallBlocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "RoomPlans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomPlans",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WallBlock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionX = table.Column<double>(nullable: false),
                    PositionY = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Rotation = table.Column<int>(nullable: false),
                    RoomPlanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WallBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WallBlock_RoomPlans_RoomPlanId",
                        column: x => x.RoomPlanId,
                        principalTable: "RoomPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WallBlock_RoomPlanId",
                table: "WallBlock",
                column: "RoomPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WallBlock");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "RoomPlans");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomPlans");
        }
    }
}
