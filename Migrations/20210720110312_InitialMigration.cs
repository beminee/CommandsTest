using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommandsTest.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Description", "Key" },
                values: new object[] { new Guid("718c1632-7a63-4bae-95dc-fdb3bc7f4328"), "Description 1", "Key 1" });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Description", "Key" },
                values: new object[] { new Guid("83172ede-5931-4881-bd0f-bf1790d4ba65"), "Description 2", "Key 2" });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Description", "Key" },
                values: new object[] { new Guid("ba5e6122-709b-43e6-8082-244d3183a3e2"), "Description 3", "Key 3" });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Description", "Key" },
                values: new object[] { new Guid("a62381fa-fb5d-4b7a-8b79-252879dfe8ba"), "Description 4", "Key 4" });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Description", "Key" },
                values: new object[] { new Guid("d94de2b9-c058-4599-9e73-5e4bb94283df"), "Description 5", "Key 5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
