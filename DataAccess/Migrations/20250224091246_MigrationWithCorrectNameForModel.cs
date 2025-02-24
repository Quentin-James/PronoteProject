using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MigrationWithCorrectNameForModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_User_UsersId",
                table: "Absences");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_User_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_User_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_User_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolsId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_User_UsersId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_User_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_User_UsersId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Id_school",
                table: "Classes");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Teachers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Teachers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Teachers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Id_subject",
                table: "Teachers",
                newName: "IdSubject");

            migrationBuilder.RenameColumn(
                name: "Id_school",
                table: "Teachers",
                newName: "IdSchool");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Subjects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Schools",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Parents",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Parents",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Parents",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Id_user",
                table: "Parents",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "Id_subject",
                table: "Grades",
                newName: "IdSubject");

            migrationBuilder.RenameColumn(
                name: "Date_Note",
                table: "Grades",
                newName: "GradeDate");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Classrooms",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Capacité",
                table: "Classrooms",
                newName: "Capability");

            migrationBuilder.RenameColumn(
                name: "SchoolsId",
                table: "Classes",
                newName: "SchoolId");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Classes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Niveau",
                table: "Classes",
                newName: "Level");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_SchoolsId",
                table: "Classes",
                newName: "IX_Classes_SchoolId");

            migrationBuilder.RenameColumn(
                name: "Justifie",
                table: "Absences",
                newName: "Justification");

            migrationBuilder.RenameColumn(
                name: "Date_fin",
                table: "Absences",
                newName: "FinishingDate");

            migrationBuilder.RenameColumn(
                name: "Date_debut",
                table: "Absences",
                newName: "BeginingDate");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_Users_UsersId",
                table: "Absences",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Users_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Users_UsersId",
                table: "Parents",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Users_UsersId",
                table: "Teachers",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_Users_UsersId",
                table: "Absences");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Users_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Users_UsersId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Users_UsersId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Teachers",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Teachers",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "IdSubject",
                table: "Teachers",
                newName: "Id_subject");

            migrationBuilder.RenameColumn(
                name: "IdSchool",
                table: "Teachers",
                newName: "Id_school");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Teachers",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Subjects",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Schools",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Parents",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Parents",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Parents",
                newName: "Id_user");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Parents",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "IdSubject",
                table: "Grades",
                newName: "Id_subject");

            migrationBuilder.RenameColumn(
                name: "GradeDate",
                table: "Grades",
                newName: "Date_Note");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Classrooms",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "Capability",
                table: "Classrooms",
                newName: "Capacité");

            migrationBuilder.RenameColumn(
                name: "SchoolId",
                table: "Classes",
                newName: "SchoolsId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Classes",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Classes",
                newName: "Niveau");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_SchoolId",
                table: "Classes",
                newName: "IX_Classes_SchoolsId");

            migrationBuilder.RenameColumn(
                name: "Justification",
                table: "Absences",
                newName: "Justifie");

            migrationBuilder.RenameColumn(
                name: "FinishingDate",
                table: "Absences",
                newName: "Date_fin");

            migrationBuilder.RenameColumn(
                name: "BeginingDate",
                table: "Absences",
                newName: "Date_debut");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "User",
                newName: "Nom");

            migrationBuilder.AddColumn<int>(
                name: "Id_school",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_User_UsersId",
                table: "Absences",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_User_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_User_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_User_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolsId",
                table: "Classes",
                column: "SchoolsId",
                principalTable: "Schools",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_User_UsersId",
                table: "Parents",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_User_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_User_UsersId",
                table: "Teachers",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
