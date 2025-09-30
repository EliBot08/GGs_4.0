using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GGs.Server.Migrations
{
    public partial class AddIdempotencyRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdempotencyRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<string>(type: "TEXT", nullable: false),
                    RequestHash = table.Column<string>(type: "TEXT", nullable: false),
                    ResponseJson = table.Column<string>(type: "TEXT", nullable: false),
                    StatusCode = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_IdempotencyRecords", x => x.Id); });

            migrationBuilder.CreateIndex(
                name: "IX_IdempotencyRecords_Key",
                table: "IdempotencyRecords",
                column: "Key",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "IdempotencyRecords");
        }
    }
}

