using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodAPI.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Fat = table.Column<double>(type: "float", nullable: false),
                    Cholestrol = table.Column<double>(type: "float", nullable: false),
                    Sodium = table.Column<double>(type: "float", nullable: false),
                    Potassium = table.Column<double>(type: "float", nullable: false),
                    Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Vitamin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calories", "Carbohydrates", "Cholestrol", "Description", "Fat", "Image", "Name", "Potassium", "Protein", "Sodium", "Vitamin" },
                values: new object[] { 1, 95.0, 25.0, 0.0, "This is an apple", 0.29999999999999999, "https://www.busybeecandles.co.uk/wp-content/uploads/2013/08/apple-benefits32.jpg", "APPLE", 195.0, 0.5, 1.8, "A" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calories", "Carbohydrates", "Cholestrol", "Description", "Fat", "Image", "Name", "Potassium", "Protein", "Sodium", "Vitamin" },
                values: new object[] { 2, 95.0, 25.0, 0.0, "This is an apple", 0.29999999999999999, "https://assets.vogue.com/photos/5deec371e52fbd00086eb68b/16:9/w_2959,h_1664,c_limit/promo-banana.jpg", "BANANA", 195.0, 0.5, 1.8, "B" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calories", "Carbohydrates", "Cholestrol", "Description", "Fat", "Image", "Name", "Potassium", "Protein", "Sodium", "Vitamin" },
                values: new object[] { 3, 95.0, 25.0, 0.0, "This is an apple", 0.29999999999999999, "https://5.imimg.com/data5/KA/KH/MY-22541476/stark-crimson-pears-500x500.jpg", "PEAR", 195.0, 0.5, 1.8, "C" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
