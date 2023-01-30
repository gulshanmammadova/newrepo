using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarModelMarka.Migrations
{
    public partial class ConnectedClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Markas_MarkaId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_MarkaId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ModelId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MarkaId",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Cars",
                newName: "MarkalId");

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Markas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MarkaId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Markas_ModelId",
                table: "Markas",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MarkaId",
                table: "Cars",
                column: "MarkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Markas_MarkaId",
                table: "Cars",
                column: "MarkaId",
                principalTable: "Markas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Markas_Models_ModelId",
                table: "Markas",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Markas_MarkaId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Markas_Models_ModelId",
                table: "Markas");

            migrationBuilder.DropIndex(
                name: "IX_Markas_ModelId",
                table: "Markas");

            migrationBuilder.DropIndex(
                name: "IX_Cars_MarkaId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Markas");

            migrationBuilder.DropColumn(
                name: "MarkaId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "MarkalId",
                table: "Cars",
                newName: "ModelId");

            migrationBuilder.AddColumn<int>(
                name: "MarkaId",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Models_MarkaId",
                table: "Models",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Markas_MarkaId",
                table: "Models",
                column: "MarkaId",
                principalTable: "Markas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
