using Microsoft.EntityFrameworkCore.Migrations;

namespace ArApiProvider.Migrations
{
    public partial class WallBlocks2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WallBlock_RoomPlans_RoomPlanId",
                table: "WallBlock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WallBlock",
                table: "WallBlock");

            migrationBuilder.RenameTable(
                name: "WallBlock",
                newName: "WallBlocks");

            migrationBuilder.RenameIndex(
                name: "IX_WallBlock_RoomPlanId",
                table: "WallBlocks",
                newName: "IX_WallBlocks_RoomPlanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WallBlocks",
                table: "WallBlocks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WallBlocks_RoomPlans_RoomPlanId",
                table: "WallBlocks",
                column: "RoomPlanId",
                principalTable: "RoomPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WallBlocks_RoomPlans_RoomPlanId",
                table: "WallBlocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WallBlocks",
                table: "WallBlocks");

            migrationBuilder.RenameTable(
                name: "WallBlocks",
                newName: "WallBlock");

            migrationBuilder.RenameIndex(
                name: "IX_WallBlocks_RoomPlanId",
                table: "WallBlock",
                newName: "IX_WallBlock_RoomPlanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WallBlock",
                table: "WallBlock",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WallBlock_RoomPlans_RoomPlanId",
                table: "WallBlock",
                column: "RoomPlanId",
                principalTable: "RoomPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
