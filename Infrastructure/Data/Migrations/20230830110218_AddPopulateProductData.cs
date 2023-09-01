using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations

{
	/// <inheritdoc />
	public partial class AddPopulateProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO products VALUES('CAP')");
            migrationBuilder.Sql("INSERT INTO products VALUES('SHOES')");
            migrationBuilder.Sql("INSERT INTO products VALUES('WATCH')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
