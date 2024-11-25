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
                    { 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(2690), "Which keyword is used to define a method in C# that does not return a value?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(2690) },
                    { 2, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3410), "What is the default access modifier for a class in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3410) },
                    { 3, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3420), "Which of the following is NOT a value type in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3420) },
                    { 4, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3420), "What is the purpose of the 'using' statement in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3420) },
                    { 5, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3420), "What is the correct way to declare a nullable int in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3420) },
                    { 6, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430), "What does the 'is' keyword do in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430) },
                    { 7, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430), "Which exception is thrown when accessing an array element out of bounds in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430) },
                    { 8, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430), "What is the purpose of the 'async' keyword in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430) },
                    { 9, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430), "Which collection in C# is used to store key-value pairs?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3430) },
                    { 10, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3440), "What is the base class for all types in C#?", 0, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3440) }
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(780), "Test on the fundamendals of csharp", "C# Basics", new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.InsertData(
                table: "Option",
                columns: new[] { "Id", "Correct", "CreatedAt", "Description", "QuestionId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3910), "void", 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(3910) },
                    { 2, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5230), "return", 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5230) },
                    { 3, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240), "method", 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240) },
                    { 4, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240), "empty", 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240) },
                    { 5, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240), "private", 2, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240) },
                    { 6, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240), "public", 2, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5240) },
                    { 7, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250), "internal", 2, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250) },
                    { 8, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250), "protected", 2, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250) },
                    { 9, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250), "int", 3, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250) },
                    { 10, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250), "float", 3, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250) },
                    { 11, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250), "decimal", 3, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250) },
                    { 12, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250), "string", 3, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250) },
                    { 13, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250), "To import namespaces", 4, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5250) },
                    { 14, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260), "To declare variables", 4, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260) },
                    { 15, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260), "To execute cleanup code", 4, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260) },
                    { 16, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260), "To define methods", 4, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260) },
                    { 17, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260), "int num = null;", 5, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5260) },
                    { 18, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5290), "int? num = null;", 5, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5290) },
                    { 19, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5290), "nullable int num;", 5, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5290) },
                    { 20, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300), "num = null;", 5, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300) },
                    { 21, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300), "Checks if an object is a specific type", 6, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300) },
                    { 22, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300), "Creates a new object", 6, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300) },
                    { 23, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300), "Casts an object to a specific type", 6, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300) },
                    { 24, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300), "Compares two objects for equality", 6, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300) },
                    { 25, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300), "ArgumentException", 7, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300) },
                    { 26, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300), "IndexOutOfRangeException", 7, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5300) },
                    { 27, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310), "OutOfMemoryException", 7, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310) },
                    { 28, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310), "NullReferenceException", 7, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310) },
                    { 29, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310), "To define a background thread", 8, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310) },
                    { 30, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310), "To mark a method for asynchronous execution", 8, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310) },
                    { 31, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310), "To pause a method", 8, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310) },
                    { 32, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310), "To cancel a task", 8, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310) },
                    { 33, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310), "List", 9, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5310) },
                    { 34, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320), "Array", 9, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320) },
                    { 35, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320), "Dictionary", 9, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320) },
                    { 36, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320), "Queue", 9, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320) },
                    { 37, true, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320), "System.Object", 10, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320) },
                    { 38, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320), "System.Type", 10, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320) },
                    { 39, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320), "System.Base", 10, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320) },
                    { 40, false, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320), "System.Class", 10, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5320) }
                });

            migrationBuilder.InsertData(
                table: "TestQuestion",
                columns: new[] { "QuestionId", "TestId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(5680) },
                    { 2, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320) },
                    { 3, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320) },
                    { 4, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320) },
                    { 5, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6320) },
                    { 6, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330) },
                    { 7, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330) },
                    { 8, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330) },
                    { 9, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330) },
                    { 10, 1, new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 11, 25, 3, 30, 14, 216, DateTimeKind.Utc).AddTicks(6330) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Option_QuestionId",
                table: "Option",
                column: "QuestionId");

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
                name: "TestQuestion");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
