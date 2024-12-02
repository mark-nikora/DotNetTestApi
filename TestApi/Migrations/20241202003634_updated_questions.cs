using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApi.Migrations
{
    /// <inheritdoc />
    public partial class updated_questions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Option",
                columns: new[] { "Id", "Correct", "CreatedAt", "Description", "QuestionId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9550), "10", 11, new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9550) },
                    { 2, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(830), "11", 11, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(830) },
                    { 3, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), "5", 11, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) },
                    { 4, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), "0", 11, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) },
                    { 5, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), "1", 12, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) },
                    { 6, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), "2", 12, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) },
                    { 7, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), "3", 12, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) },
                    { 8, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850), "4", 12, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850) },
                    { 9, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850), "Syntax error, missing bracket", 13, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850) },
                    { 10, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850), "No error", 13, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850) },
                    { 11, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), "Syntax error, missing semicolon", 13, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) },
                    { 12, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), "Logic error", 13, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) },
                    { 13, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), "Sorts the list by length of each string", 14, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) },
                    { 14, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), "Filters the list based on length", 14, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) },
                    { 15, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), "Returns the list without modification", 14, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) },
                    { 16, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), "Orders the list by string content", 14, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) },
                    { 17, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), "IndexOutOfRangeException", 15, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) },
                    { 18, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), "NullReferenceException", 15, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) },
                    { 19, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), "ArgumentOutOfRangeException", 15, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) },
                    { 20, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), "ArgumentNullException", 15, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) },
                    { 21, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "Returns 42", 16, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 22, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "Returns 0", 16, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 23, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "Returns null", 16, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 24, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "Throws an exception", 16, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 25, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "It allows asynchronous execution", 17, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 26, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "It pauses the execution of a method", 17, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 27, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "It throws an exception", 17, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 28, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), "It defines a lambda expression", 17, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) },
                    { 29, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), "Add the closing parenthesis", 18, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) },
                    { 30, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), "Add a semicolon after 'HasValue'", 18, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) },
                    { 31, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), "Change 'HasValue' to 'Value'", 18, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) },
                    { 32, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), "Change 'num' to 'num.Value'", 18, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) },
                    { 33, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), "555", 19, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) },
                    { 34, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), "55", 19, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) },
                    { 35, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), "50", 19, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) },
                    { 36, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), "5", 19, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) },
                    { 37, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), "Hello", 20, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) },
                    { 38, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), "Error", 20, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) },
                    { 39, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), "Nothing", 20, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) },
                    { 40, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), "null", 20, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) },
                    { 41, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), "Finds the maximum value", 21, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) },
                    { 42, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), "Sorts the list", 21, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) },
                    { 43, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), "Filters the list", 21, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) },
                    { 44, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), "Reverses the list", 21, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) },
                    { 45, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), "Yes", 22, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) },
                    { 46, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), "No", 22, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) },
                    { 47, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), "Maybe", 22, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) },
                    { 48, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), "None", 22, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) },
                    { 49, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), "Increments the value of x", 23, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) },
                    { 50, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), "Decrements the value of x", 23, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) },
                    { 51, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "Compares the value of x", 23, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 52, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "Assigns a new value to x", 23, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 53, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "NullReferenceException", 24, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 54, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "IndexOutOfRangeException", 24, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 55, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "ArgumentNullException", 24, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 56, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "ArgumentOutOfRangeException", 24, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 57, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "True", 25, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 58, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), "False", 25, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) },
                    { 59, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), "No Output", 25, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) },
                    { 60, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), "Error", 25, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) },
                    { 61, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), "012", 26, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) },
                    { 62, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), "123", 26, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) },
                    { 63, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), "321", 26, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) },
                    { 64, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), "None", 26, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) },
                    { 65, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), "True", 27, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) },
                    { 66, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000), "False", 27, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000) },
                    { 67, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000), "Error", 27, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000) },
                    { 68, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), "None", 27, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) },
                    { 69, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), "Fixes the lambda expression", 28, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) },
                    { 70, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), "Throws a compile error", 28, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) },
                    { 71, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), "Does nothing", 28, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) },
                    { 72, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), "Creates an infinite loop", 28, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) },
                    { 73, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "2", 29, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) },
                    { 74, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "1", 29, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) },
                    { 75, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "3", 29, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) },
                    { 76, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "4", 29, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) },
                    { 77, true, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "Default", 30, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) },
                    { 78, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "One", 30, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) },
                    { 79, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "Two", 30, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) },
                    { 80, false, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), "None", 30, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1040) }
                });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(7930), "Which keyword is used to define a method in C# that does not return a value?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950), "What is the default access modifier for a class in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950), "Which of the following is NOT a value type in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960), "What is the purpose of the 'using' statement in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960), "What is the correct way to declare a nullable int in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), "What does the 'is' keyword do in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), "Which exception is thrown when accessing an array element out of bounds in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), "What is the purpose of the 'async' keyword in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), "Which collection in C# is used to store key-value pairs?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9000), "What is the base class for all types in C#?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "int x = 10; int y = x++; Console.WriteLine(y);", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), "What is the output of this code?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "int[] numbers = { 1, 2, 3 }; var result = numbers.Where(x => x > 1).Count();", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), "What will this code return?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "if(x == 10) { Console.WriteLine(\"Hello\" }", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), "Identify the error in the following code.", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "var query = list.OrderBy(x => x.Length).ToList();", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), "What does this LINQ query do?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "string[] arr = new string[1]; arr[1] = \"OutOfBounds\";", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), "What exception will this code throw?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "Task<int> GetResultAsync() { return Task.FromResult(42); }", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9020), "What does this method return?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "await Task.Delay(1000);", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), "What is the purpose of the 'await' keyword in this code?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "int? num = 5; if(num.HasValue Console.WriteLine(num.Value);", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), "Fix the syntax error in the following code.", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "Console.WriteLine(\"5\" + 5 + 5);", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), "What will this print to the console?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "Action greet = () => Console.WriteLine(\"Hello\"); greet();", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), "What does this delegate do?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "var max = numbers.Max();", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), "Explain what this LINQ method does.", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "int x = 5; Console.WriteLine(x > 3 ? \"Yes\" : \"No\");", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), "What will be the output of this ternary operator?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "void Increment(ref int x) { x++; }", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), "What does the 'ref' keyword do in this code?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "object obj = null; Console.WriteLine(obj.ToString());", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), "What exception does this code throw?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "if(true) Console.WriteLine(\"True\"); else Console.WriteLine(\"False\");", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), "What is the output of this conditional statement?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "for(int i = 0; i < 3; i++) Console.Write(i);", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), "What will this loop print?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "bool result = (5 == 5) && (3 < 4);", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), "What is the result of this expression?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "Func<int, int> square = x => return x * x;", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120), "Fix the issue in this lambda expression.", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "int[] nums = {1, 2, 3}; Console.WriteLine(nums[1]);", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120), "What will this array print?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "switch(2) { case 1: Console.WriteLine(\"One\"); break; default: Console.WriteLine(\"Default\"); }", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120), "What does this 'switch' statement output?", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OutOf", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2470), 30, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Mark", "OutOf", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(4030), 25, 30, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(5980), "Test on the fundamentals of C#", new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.InsertData(
                table: "TestQuestion",
                columns: new[] { "QuestionId", "TestId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030) },
                    { 5, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030) },
                    { 6, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 7, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 8, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 9, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 10, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 11, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 12, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 13, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) },
                    { 14, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 15, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 16, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 17, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 18, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 19, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 20, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 21, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) },
                    { 22, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 23, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 24, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 25, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 26, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 27, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 28, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 29, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) },
                    { 30, 1, new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2070) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(9670), "Which of the following are reference types in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(690), "Which of the following are valid data types in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which access modifiers are available in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which are valid loop constructs in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which of the following statements about arrays in C# are true?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700), "Which of the following can be used to handle exceptions in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730), "Which LINQ methods are used for filtering?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730), "Which are value types in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "What keywords can be used for asynchronous programming in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "Which are valid collection types in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "int x = 5; int y = x++; Console.WriteLine(y); // Output?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "What will be the output of the following code?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "if(x == 10) { Console.WriteLine(\"Hello\" }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "Fix the syntax error in this code snippet.", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "var result = numbers.Where(x => x > 5).ToList();", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "What does this LINQ query return?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "string[] arr = new string[2]; arr[2] = \"test\";", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740), "Identify the error in the following code.", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "public List<int> GetEvenNumbers(List<int> numbers) { var result = new List<int>(); foreach (var num in numbers) { if (num % 2 == 0) result.Add(num); } return result; }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "Rewrite this method to use LINQ.", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "Action<string> greet = name => Console.WriteLine($\"Hello, {name}\"); greet(\"World\");", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "Explain what this delegate does.", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "int x = 10; Console.WriteLine(x == 10 ? \"Equal\" : \"Not Equal\");", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What does this code print?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "bool TryParse(string input, out int result) { return int.TryParse(input, out result); }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What does the 'out' keyword do in this context?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "Console.WriteLine(\"A\" + 1 + 1);", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What is the output of the following code?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "async Task<int> GetNumberAsync() { return await Task.FromResult(42); }", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750), "What will this async method return?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "Which keyword is used to define a method that does not return a value?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What is the default access modifier for a class in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What is the purpose of the 'using' statement in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What is the correct way to declare a nullable int in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "Which exception is thrown when accessing an array element out of bounds in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760), "What does the 'is' keyword do in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "What is the base class for all types in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "Which collection in C# is used to store key-value pairs?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "What is the purpose of the 'async' keyword in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Code", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770), "Which of the following is NOT a value type in C#?", new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Code", "CreatedAt", "Description", "Mark", "UpdatedAt" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OutOf", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(2270), 10, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Mark", "OutOf", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 3, 10, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.InsertData(
                table: "Result",
                columns: new[] { "Id", "CreatedAt", "Mark", "OutOf", "TestId", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 5, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), "Keisha" },
                    { 4, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 8, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), "Throca" },
                    { 5, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), 3, 10, 1, new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(4180), "Medina" }
                });

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(7720), "Test on the fundamentals of C#.", new DateTime(2024, 12, 1, 23, 59, 33, 887, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1140), new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790), new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790), new DateTime(2024, 12, 1, 23, 59, 33, 888, DateTimeKind.Utc).AddTicks(1790) });
        }
    }
}
