using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations.SubCategorycontextMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategoriesDb",
                columns: table => new
                {
                    C_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cname = table.Column<string>(nullable: true),
                    Subid = table.Column<int>(nullable: false),
                    Subname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoriesDb", x => x.C_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategoriesDb");
        }
    }
}
