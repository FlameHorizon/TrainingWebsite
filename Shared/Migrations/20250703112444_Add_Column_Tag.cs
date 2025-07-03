using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shared.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Tag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "WorkoutPlans",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "WorkoutPlans");
        }
    }
}
