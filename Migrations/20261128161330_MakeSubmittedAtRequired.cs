using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exam_system.Migrations
{
    /// <inheritdoc />
    public partial class MakeSubmittedAtRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttemptAnswer_AttemptQuestionOptions_SelectedOptionId",
                table: "AttemptAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptAnswer_AttemptQuestion_AttemptQuestionId",
                table: "AttemptAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptAnswer_QuizAttempt_AttemptId",
                table: "AttemptAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestion_Question_OriginalQuestionId",
                table: "AttemptQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestion_QuizAttempt_AttemptId",
                table: "AttemptQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestionOptions_AttemptQuestion_AttemptQuestionId",
                table: "AttemptQuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestionOptions_Option_OriginalOptionId",
                table: "AttemptQuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOption_Option_OptionId",
                table: "QuestionOption");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOption_Question_QuestionId",
                table: "QuestionOption");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempt_AspNetUsers_StudentId",
                table: "QuizAttempt");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempt_Quizzes_QuizId",
                table: "QuizAttempt");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempt_Quizzes_QuizId1",
                table: "QuizAttempt");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizQuestion_Question_QuestionId",
                table: "QuizQuestion");

            migrationBuilder.DropIndex(
                name: "IX_AttemptQuestionOptions_AttemptQuestionId",
                table: "AttemptQuestionOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizAttempt",
                table: "QuizAttempt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionOption",
                table: "QuestionOption");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOption_QuestionId",
                table: "QuestionOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Option",
                table: "Option");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttemptQuestion",
                table: "AttemptQuestion");

            migrationBuilder.DropIndex(
                name: "IX_AttemptQuestion_AttemptId",
                table: "AttemptQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttemptAnswer",
                table: "AttemptAnswer");

            migrationBuilder.DropIndex(
                name: "IX_AttemptAnswer_AttemptQuestionId",
                table: "AttemptAnswer");

            migrationBuilder.RenameTable(
                name: "QuizAttempt",
                newName: "QuizAttempts");

            migrationBuilder.RenameTable(
                name: "QuestionOption",
                newName: "QuestionOptions");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Option",
                newName: "Options");

            migrationBuilder.RenameTable(
                name: "AttemptQuestion",
                newName: "AttemptQuestions");

            migrationBuilder.RenameTable(
                name: "AttemptAnswer",
                newName: "AttemptAnswers");

            migrationBuilder.RenameIndex(
                name: "IX_QuizAttempt_StudentId",
                table: "QuizAttempts",
                newName: "IX_QuizAttempts_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_QuizAttempt_QuizId1",
                table: "QuizAttempts",
                newName: "IX_QuizAttempts_QuizId1");

            migrationBuilder.RenameIndex(
                name: "IX_QuizAttempt_QuizId",
                table: "QuizAttempts",
                newName: "IX_QuizAttempts_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionOption_OptionId",
                table: "QuestionOptions",
                newName: "IX_QuestionOptions_OptionId");

            migrationBuilder.RenameIndex(
                name: "IX_AttemptQuestion_OriginalQuestionId",
                table: "AttemptQuestions",
                newName: "IX_AttemptQuestions_OriginalQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_AttemptAnswer_SelectedOptionId",
                table: "AttemptAnswers",
                newName: "IX_AttemptAnswers_SelectedOptionId");

            migrationBuilder.RenameIndex(
                name: "IX_AttemptAnswer_AttemptId",
                table: "AttemptAnswers",
                newName: "IX_AttemptAnswers_AttemptId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmittedAt",
                table: "QuizAttempts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "QuizTitleSnapShot",
                table: "QuizAttempts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PassScoreSnapShot",
                table: "QuizAttempts",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "NavigationVersion",
                table: "QuizAttempts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPassed",
                table: "QuizAttempts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentQuestionIndex",
                table: "QuizAttempts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "AttemptScore",
                table: "QuizAttempts",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "QuizAttempts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "QuizAttempts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "QuizAttemptId",
                table: "AttemptAnswers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizAttempts",
                table: "QuizAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionOptions",
                table: "QuestionOptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Options",
                table: "Options",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttemptQuestions",
                table: "AttemptQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttemptAnswers",
                table: "AttemptAnswers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptQuestionOptions_AttemptQuestionId_OptionOrder",
                table: "AttemptQuestionOptions",
                columns: new[] { "AttemptQuestionId", "OptionOrder" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttempts_ApplicationUserId",
                table: "QuizAttempts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttempts_StudentId_QuizId",
                table: "QuizAttempts",
                columns: new[] { "StudentId", "QuizId" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId",
                unique: true,
                filter: "[IsCorrect] = 1 AND [IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId_OptionId",
                table: "QuestionOptions",
                columns: new[] { "QuestionId", "OptionId" },
                unique: true,
                filter: "[IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId_OrderIndex",
                table: "QuestionOptions",
                columns: new[] { "QuestionId", "OrderIndex" },
                unique: true,
                filter: "[IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_IsDeleted",
                table: "Questions",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Options_IsDeleted",
                table: "Options",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptQuestions_AttemptId_OrderIndex",
                table: "AttemptQuestions",
                columns: new[] { "AttemptId", "OrderIndex" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttemptAnswers_AttemptQuestionId",
                table: "AttemptAnswers",
                column: "AttemptQuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttemptAnswers_QuizAttemptId",
                table: "AttemptAnswers",
                column: "QuizAttemptId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptAnswers_AttemptQuestionOptions_SelectedOptionId",
                table: "AttemptAnswers",
                column: "SelectedOptionId",
                principalTable: "AttemptQuestionOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptAnswers_AttemptQuestions_AttemptQuestionId",
                table: "AttemptAnswers",
                column: "AttemptQuestionId",
                principalTable: "AttemptQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptAnswers_QuizAttempts_AttemptId",
                table: "AttemptAnswers",
                column: "AttemptId",
                principalTable: "QuizAttempts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptAnswers_QuizAttempts_QuizAttemptId",
                table: "AttemptAnswers",
                column: "QuizAttemptId",
                principalTable: "QuizAttempts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestionOptions_AttemptQuestions_AttemptQuestionId",
                table: "AttemptQuestionOptions",
                column: "AttemptQuestionId",
                principalTable: "AttemptQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestionOptions_Options_OriginalOptionId",
                table: "AttemptQuestionOptions",
                column: "OriginalOptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestions_Questions_OriginalQuestionId",
                table: "AttemptQuestions",
                column: "OriginalQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestions_QuizAttempts_AttemptId",
                table: "AttemptQuestions",
                column: "AttemptId",
                principalTable: "QuizAttempts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOptions_Options_OptionId",
                table: "QuestionOptions",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempts_AspNetUsers_ApplicationUserId",
                table: "QuizAttempts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempts_AspNetUsers_StudentId",
                table: "QuizAttempts",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempts_Quizzes_QuizId",
                table: "QuizAttempts",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempts_Quizzes_QuizId1",
                table: "QuizAttempts",
                column: "QuizId1",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizQuestion_Questions_QuestionId",
                table: "QuizQuestion",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttemptAnswers_AttemptQuestionOptions_SelectedOptionId",
                table: "AttemptAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptAnswers_AttemptQuestions_AttemptQuestionId",
                table: "AttemptAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptAnswers_QuizAttempts_AttemptId",
                table: "AttemptAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptAnswers_QuizAttempts_QuizAttemptId",
                table: "AttemptAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestionOptions_AttemptQuestions_AttemptQuestionId",
                table: "AttemptQuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestionOptions_Options_OriginalOptionId",
                table: "AttemptQuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestions_Questions_OriginalQuestionId",
                table: "AttemptQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AttemptQuestions_QuizAttempts_AttemptId",
                table: "AttemptQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOptions_Options_OptionId",
                table: "QuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempts_AspNetUsers_ApplicationUserId",
                table: "QuizAttempts");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempts_AspNetUsers_StudentId",
                table: "QuizAttempts");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempts_Quizzes_QuizId",
                table: "QuizAttempts");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizAttempts_Quizzes_QuizId1",
                table: "QuizAttempts");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizQuestion_Questions_QuestionId",
                table: "QuizQuestion");

            migrationBuilder.DropIndex(
                name: "IX_AttemptQuestionOptions_AttemptQuestionId_OptionOrder",
                table: "AttemptQuestionOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizAttempts",
                table: "QuizAttempts");

            migrationBuilder.DropIndex(
                name: "IX_QuizAttempts_ApplicationUserId",
                table: "QuizAttempts");

            migrationBuilder.DropIndex(
                name: "IX_QuizAttempts_StudentId_QuizId",
                table: "QuizAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_IsDeleted",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionOptions",
                table: "QuestionOptions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId_OptionId",
                table: "QuestionOptions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId_OrderIndex",
                table: "QuestionOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Options",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_IsDeleted",
                table: "Options");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttemptQuestions",
                table: "AttemptQuestions");

            migrationBuilder.DropIndex(
                name: "IX_AttemptQuestions_AttemptId_OrderIndex",
                table: "AttemptQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttemptAnswers",
                table: "AttemptAnswers");

            migrationBuilder.DropIndex(
                name: "IX_AttemptAnswers_AttemptQuestionId",
                table: "AttemptAnswers");

            migrationBuilder.DropIndex(
                name: "IX_AttemptAnswers_QuizAttemptId",
                table: "AttemptAnswers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "QuizAttempts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "QuizAttempts");

            migrationBuilder.DropColumn(
                name: "QuizAttemptId",
                table: "AttemptAnswers");

            migrationBuilder.RenameTable(
                name: "QuizAttempts",
                newName: "QuizAttempt");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "QuestionOptions",
                newName: "QuestionOption");

            migrationBuilder.RenameTable(
                name: "Options",
                newName: "Option");

            migrationBuilder.RenameTable(
                name: "AttemptQuestions",
                newName: "AttemptQuestion");

            migrationBuilder.RenameTable(
                name: "AttemptAnswers",
                newName: "AttemptAnswer");

            migrationBuilder.RenameIndex(
                name: "IX_QuizAttempts_StudentId",
                table: "QuizAttempt",
                newName: "IX_QuizAttempt_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_QuizAttempts_QuizId1",
                table: "QuizAttempt",
                newName: "IX_QuizAttempt_QuizId1");

            migrationBuilder.RenameIndex(
                name: "IX_QuizAttempts_QuizId",
                table: "QuizAttempt",
                newName: "IX_QuizAttempt_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionOptions_OptionId",
                table: "QuestionOption",
                newName: "IX_QuestionOption_OptionId");

            migrationBuilder.RenameIndex(
                name: "IX_AttemptQuestions_OriginalQuestionId",
                table: "AttemptQuestion",
                newName: "IX_AttemptQuestion_OriginalQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_AttemptAnswers_SelectedOptionId",
                table: "AttemptAnswer",
                newName: "IX_AttemptAnswer_SelectedOptionId");

            migrationBuilder.RenameIndex(
                name: "IX_AttemptAnswers_AttemptId",
                table: "AttemptAnswer",
                newName: "IX_AttemptAnswer_AttemptId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmittedAt",
                table: "QuizAttempt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuizTitleSnapShot",
                table: "QuizAttempt",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<decimal>(
                name: "PassScoreSnapShot",
                table: "QuizAttempt",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "NavigationVersion",
                table: "QuizAttempt",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsPassed",
                table: "QuizAttempt",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentQuestionIndex",
                table: "QuizAttempt",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "AttemptScore",
                table: "QuizAttempt",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2,
                oldDefaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizAttempt",
                table: "QuizAttempt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionOption",
                table: "QuestionOption",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Option",
                table: "Option",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttemptQuestion",
                table: "AttemptQuestion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttemptAnswer",
                table: "AttemptAnswer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptQuestionOptions_AttemptQuestionId",
                table: "AttemptQuestionOptions",
                column: "AttemptQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOption_QuestionId",
                table: "QuestionOption",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptQuestion_AttemptId",
                table: "AttemptQuestion",
                column: "AttemptId");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptAnswer_AttemptQuestionId",
                table: "AttemptAnswer",
                column: "AttemptQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptAnswer_AttemptQuestionOptions_SelectedOptionId",
                table: "AttemptAnswer",
                column: "SelectedOptionId",
                principalTable: "AttemptQuestionOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptAnswer_AttemptQuestion_AttemptQuestionId",
                table: "AttemptAnswer",
                column: "AttemptQuestionId",
                principalTable: "AttemptQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptAnswer_QuizAttempt_AttemptId",
                table: "AttemptAnswer",
                column: "AttemptId",
                principalTable: "QuizAttempt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestion_Question_OriginalQuestionId",
                table: "AttemptQuestion",
                column: "OriginalQuestionId",
                principalTable: "Question",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestion_QuizAttempt_AttemptId",
                table: "AttemptQuestion",
                column: "AttemptId",
                principalTable: "QuizAttempt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestionOptions_AttemptQuestion_AttemptQuestionId",
                table: "AttemptQuestionOptions",
                column: "AttemptQuestionId",
                principalTable: "AttemptQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptQuestionOptions_Option_OriginalOptionId",
                table: "AttemptQuestionOptions",
                column: "OriginalOptionId",
                principalTable: "Option",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOption_Option_OptionId",
                table: "QuestionOption",
                column: "OptionId",
                principalTable: "Option",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOption_Question_QuestionId",
                table: "QuestionOption",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempt_AspNetUsers_StudentId",
                table: "QuizAttempt",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempt_Quizzes_QuizId",
                table: "QuizAttempt",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAttempt_Quizzes_QuizId1",
                table: "QuizAttempt",
                column: "QuizId1",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuizQuestion_Question_QuestionId",
                table: "QuizQuestion",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
