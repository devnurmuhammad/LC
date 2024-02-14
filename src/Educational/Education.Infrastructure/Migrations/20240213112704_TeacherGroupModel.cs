using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Education.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TeacherGroupModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroup_Groups_GroupId",
                table: "TeacherGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroup_Teachers_TeacherId",
                table: "TeacherGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherGroup",
                table: "TeacherGroup");

            migrationBuilder.RenameTable(
                name: "TeacherGroup",
                newName: "TeachersGroups");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherGroup_TeacherId",
                table: "TeachersGroups",
                newName: "IX_TeachersGroups_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherGroup_GroupId",
                table: "TeachersGroups",
                newName: "IX_TeachersGroups_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeachersGroups",
                table: "TeachersGroups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGroups_Groups_GroupId",
                table: "TeachersGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGroups_Teachers_TeacherId",
                table: "TeachersGroups",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGroups_Groups_GroupId",
                table: "TeachersGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGroups_Teachers_TeacherId",
                table: "TeachersGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeachersGroups",
                table: "TeachersGroups");

            migrationBuilder.RenameTable(
                name: "TeachersGroups",
                newName: "TeacherGroup");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersGroups_TeacherId",
                table: "TeacherGroup",
                newName: "IX_TeacherGroup_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersGroups_GroupId",
                table: "TeacherGroup",
                newName: "IX_TeacherGroup_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherGroup",
                table: "TeacherGroup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroup_Groups_GroupId",
                table: "TeacherGroup",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroup_Teachers_TeacherId",
                table: "TeacherGroup",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
