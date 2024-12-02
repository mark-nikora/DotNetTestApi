using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Code = table.Column<string>(type: "TEXT", nullable: true),
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
                columns: new[] { "Id", "Code", "CreatedAt", "Description", "Mark", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(9670), "Which of the following are reference types in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(9670) },
                    { 2, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(690), "Which of the following are valid data types in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(690) },
                    { 3, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which access modifiers are available in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) },
                    { 4, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which are valid loop constructs in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) },
                    { 5, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which of the following statements about arrays in C# are true?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) },
                    { 6, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which of the following can be used to handle exceptions in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) },
                    { 7, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730), "Which LINQ methods are used for filtering?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730) },
                    { 8, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730), "Which are value types in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730) },
                    { 9, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "What keywords can be used for asynchronous programming in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) },
                    { 10, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "Which are valid collection types in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) },
                    { 11, "int x = 5; int y = x++; Console.WriteLine(y); // Output?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "What will be the output of the following code?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) },
                    { 12, "if(x == 10) { Console.WriteLine(\"Hello\" }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "Fix the syntax error in this code snippet.", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) },
                    { 13, "var result = numbers.Where(x => x > 5).ToList();", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "What does this LINQ query return?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) },
                    { 14, "string[] arr = new string[2]; arr[2] = \"test\";", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "Identify the error in the following code.", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) },
                    { 15, "public List<int> GetEvenNumbers(List<int> numbers) { var result = new List<int>(); foreach (var num in numbers) { if (num % 2 == 0) result.Add(num); } return result; }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "Rewrite this method to use LINQ.", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) },
                    { 16, "Action<string> greet = name => Console.WriteLine($\"Hello, {name}\"); greet(\"World\");", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "Explain what this delegate does.", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) },
                    { 17, "int x = 10; Console.WriteLine(x == 10 ? \"Equal\" : \"Not Equal\");", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What does this code print?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) },
                    { 18, "bool TryParse(string input, out int result) { return int.TryParse(input, out result); }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What does the 'out' keyword do in this context?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) },
                    { 19, "Console.WriteLine(\"A\" + 1 + 1);", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What is the output of the following code?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) },
                    { 20, "async Task<int> GetNumberAsync() { return await Task.FromResult(42); }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What will this async method return?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) },
                    { 21, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "Which keyword is used to define a method that does not return a value?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) },
                    { 22, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What is the default access modifier for a class in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) },
                    { 23, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What is the purpose of the 'using' statement in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) },
                    { 24, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What is the correct way to declare a nullable int in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) },
                    { 25, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "Which exception is thrown when accessing an array element out of bounds in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) },
                    { 26, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What does the 'is' keyword do in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) },
                    { 27, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "What is the base class for all types in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) },
                    { 28, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "Which collection in C# is used to store key-value pairs?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) },
                    { 29, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "What is the purpose of the 'async' keyword in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) },
                    { 30, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "Which of the following is NOT a value type in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) },
                    { 31, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "What is the difference between 'ref' and 'out' parameters in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) },
                    { 32, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "What does the 'sealed' keyword do?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) },
                    { 33, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780), "What is the output of 'Console.WriteLine(5 / 2)'?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780) },
                    { 34, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780), "What is the main purpose of garbage collection in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780) },
                    { 35, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780), "What is boxing and unboxing in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780) },
                    { 36, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780), "What does the 'nameof' operator return?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780) },
                    { 37, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780), "What is a nullable reference type?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780) },
                    { 38, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780), "Which keyword is used to create a constant value in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(780) },
                    { 39, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(790), "What is the use of 'params' in method parameters?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(790) },
                    { 40, null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(790), "What is the role of an interface in C#?", 0, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(790) }
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(7720), "Test on the fundamentals of C#.", "C# Basics", new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.InsertData(
                table: "Result",
                columns: new[] { "Id", "CreatedAt", "Mark", "OutOf", "TestId", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(2270), 3, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(2270), "Mark" },
                    { 2, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 3, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), "Sarah" },
                    { 3, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 5, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), "Keisha" },
                    { 4, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 8, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), "Throca" },
                    { 5, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 3, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), "Medina" }
                });

            migrationBuilder.InsertData(
                table: "TestQuestion",
                columns: new[] { "QuestionId", "TestId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1140), new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1140) },
                    { 2, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790), new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790) },
                    { 3, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790), new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790) }
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
