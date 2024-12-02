using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApi.Migrations
{
    /// <inheritdoc />
    public partial class qbank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QBank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionBank",
                columns: table => new
                {
                    QBankId = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionBank", x => new { x.QuestionId, x.QBankId });
                    table.ForeignKey(
                        name: "FK_QuestionBank_QBank_QBankId",
                        column: x => x.QBankId,
                        principalTable: "QBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionBank_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4300), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1970), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2090), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2100), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 279, DateTimeKind.Utc).AddTicks(8590), new DateTime(2024, 12, 2, 4, 6, 10, 279, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4690), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5400), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 12, 2, 4, 6, 10, 280, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionBank_QBankId",
                table: "QuestionBank",
                column: "QBankId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionBank");

            migrationBuilder.DropTable(
                name: "QBank");

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9550), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(830), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Option",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(7930), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9000), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9020), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2470), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Result",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(4030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 12, 2, 0, 36, 34, 97, DateTimeKind.Utc).AddTicks(5980) });

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

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2030), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "TestQuestion",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 12, 2, 0, 36, 34, 98, DateTimeKind.Utc).AddTicks(2070) });
        }
    }
}
