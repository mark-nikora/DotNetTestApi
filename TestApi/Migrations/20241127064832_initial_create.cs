using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApi.Migrations
{
    /// <inheritdoc />
    public partial class initial_create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Mark = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Correct = table.Column<bool>(type: "INTEGER", nullable: false),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TestId = table.Column<int>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Mark = table.Column<int>(type: "INTEGER", nullable: false),
                    OutOf = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Result_Test_TestId",
                        column: x => x.TestId,
                        principalTable: "Test",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestQuestion",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestion", x => new { x.QuestionId, x.TestId });
                    table.ForeignKey(
                        name: "FK_TestQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestQuestion_Test_TestId",
                        column: x => x.TestId,
                        principalTable: "Test",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "CreatedAt", "Description", "Mark", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5150), "Which keyword is used to define a method in C# that does not return a value?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5150) },
                    { 2, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900), "What is the default access modifier for a class in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900) },
                    { 3, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900), "Which of the following is NOT a value type in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900) },
                    { 4, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900), "What is the purpose of the 'using' statement in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900) },
                    { 5, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900), "What is the correct way to declare a nullable int in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5900) },
                    { 6, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910), "What does the 'is' keyword do in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910) },
                    { 7, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910), "Which exception is thrown when accessing an array element out of bounds in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910) },
                    { 8, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910), "What is the purpose of the 'async' keyword in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910) },
                    { 9, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910), "Which collection in C# is used to store key-value pairs?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910) },
                    { 10, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910), "What is the base class for all types in C#?", 0, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(5910) }
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(3130), "Test on the fundamendals of csharp", "C# Basics", new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.InsertData(
                table: "Option",
                columns: new[] { "Id", "Correct", "CreatedAt", "Description", "QuestionId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(6390), "void", 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(6390) },
                    { 2, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7750), "return", 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7750) },
                    { 3, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7790), "method", 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7790) },
                    { 4, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800), "empty", 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800) },
                    { 5, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800), "private", 2, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800) },
                    { 6, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800), "public", 2, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800) },
                    { 7, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800), "internal", 2, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800) },
                    { 8, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800), "protected", 2, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800) },
                    { 9, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7800), "int", 3, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810) },
                    { 10, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810), "float", 3, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810) },
                    { 11, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810), "decimal", 3, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810) },
                    { 12, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810), "string", 3, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810) },
                    { 13, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810), "To import namespaces", 4, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810) },
                    { 14, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810), "To declare variables", 4, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7810) },
                    { 15, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820), "To execute cleanup code", 4, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820) },
                    { 16, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820), "To define methods", 4, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820) },
                    { 17, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820), "int num = null;", 5, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820) },
                    { 18, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820), "int? num = null;", 5, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820) },
                    { 19, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820), "nullable int num;", 5, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7820) },
                    { 20, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830), "num = null;", 5, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830) },
                    { 21, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830), "Checks if an object is a specific type", 6, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830) },
                    { 22, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830), "Creates a new object", 6, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830) },
                    { 23, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830), "Casts an object to a specific type", 6, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830) },
                    { 24, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830), "Compares two objects for equality", 6, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830) },
                    { 25, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830), "ArgumentException", 7, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7830) },
                    { 26, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7850), "IndexOutOfRangeException", 7, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7850) },
                    { 27, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7850), "OutOfMemoryException", 7, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7850) },
                    { 28, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7850), "NullReferenceException", 7, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7850) },
                    { 29, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860), "To define a background thread", 8, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860) },
                    { 30, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860), "To mark a method for asynchronous execution", 8, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860) },
                    { 31, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860), "To pause a method", 8, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860) },
                    { 32, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860), "To cancel a task", 8, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860) },
                    { 33, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860), "List", 9, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860) },
                    { 34, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860), "Array", 9, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860) },
                    { 35, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860), "Dictionary", 9, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7860) },
                    { 36, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7950), "Queue", 9, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7950) },
                    { 37, true, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960), "System.Object", 10, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960) },
                    { 38, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960), "System.Type", 10, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960) },
                    { 39, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960), "System.Base", 10, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960) },
                    { 40, false, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960), "System.Class", 10, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(7960) }
                });

            migrationBuilder.InsertData(
                table: "Result",
                columns: new[] { "Id", "CreatedAt", "Mark", "OutOf", "TestId", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9650), 3, 10, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9650), "Mark" },
                    { 2, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1780), 3, 10, 1, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1780), "Sarah" },
                    { 3, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1780), 5, 10, 1, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1780), "Keisha" },
                    { 4, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1780), 8, 10, 1, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1780), "Throca" },
                    { 5, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1790), 3, 10, 1, new DateTime(2024, 11, 27, 6, 48, 31, 999, DateTimeKind.Utc).AddTicks(1790), "Medina" }
                });

            migrationBuilder.InsertData(
                table: "TestQuestion",
                columns: new[] { "QuestionId", "TestId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(8370) },
                    { 2, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9240) },
                    { 3, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9240) },
                    { 4, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250) },
                    { 5, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250) },
                    { 6, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250) },
                    { 7, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250) },
                    { 8, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250) },
                    { 9, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250) },
                    { 10, 1, new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 11, 27, 6, 48, 31, 998, DateTimeKind.Utc).AddTicks(9250) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Option_QuestionId",
                table: "Option",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_TestId",
                table: "Result",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestion_TestId",
                table: "TestQuestion",
                column: "TestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "TestQuestion");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
