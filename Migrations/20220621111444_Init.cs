using Microsoft.EntityFrameworkCore.Migrations;

namespace agrokorm.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membranes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Lenght = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membranes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SunflowerSeeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfProduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunflowerSeeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SunFlowerViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunFlowerViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembraneConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembraneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembraneConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MembraneConfigurations_Membranes_MembraneId",
                        column: x => x.MembraneId,
                        principalTable: "Membranes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Membranes",
                columns: new[] { "Id", "Category", "Color", "Description", "IsVisible", "Lenght", "Name", "Price", "Type", "Width" },
                values: new object[,]
                {
                    { 1, 0, "Черная", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", true, 50, "Плёнка Silоfolie strong", "10092", "type 150", 10 },
                    { 2, 0, "Черная", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", true, 50, "Плёнка Silоfolie", "12414", "type 150", 10 }
                });

            migrationBuilder.InsertData(
                table: "SunFlowerViewModels",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of(The Extremes of Good and Evil) by Cicero, written in 45 BC." });

            migrationBuilder.InsertData(
                table: "SunflowerSeeds",
                columns: new[] { "Id", "Category", "IsVisible", "Name", "PlaceOfProduction", "Price", "Technology" },
                values: new object[,]
                {
                    { 20, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 стандарт 1 мелк 20", "Россия", "5695", "Классическая" },
                    { 21, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6013 элит 19", "Россия", "7886", "Классическая" },
                    { 22, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Ягуар элит 19", "Россия", "9858", "Классическая" },
                    { 23, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Ягуар станд 19", "Россия", "7886", "Классическая" },
                    { 24, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Аламо элит 20", "Россия", "9858", "Классическая" },
                    { 25, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Аламо стандарт 20", "Россия", "7886", "Классическая" },
                    { 26, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-26752 элит 19", "Россия", "9858", "Классическая" },
                    { 27, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-26752 стандарт 19", "Россия", "7886", "Классическая" },
                    { 28, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6006 элит 19", "Россия", "11172", "СУМО" },
                    { 29, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6006 стандарт 19", "Россия", "8761", "СУМО" },
                    { 30, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 496 элит 20", "Венгрия", "12047", "СУМО" },
                    { 31, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 496 элит 19", "Россия", "11172", "СУМО" },
                    { 32, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 496 стандарт 19", "Россия", "8761", "СУМО" },
                    { 33, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 498 стандарт 20", "Россия", "9419", "СУМО" },
                    { 19, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 стандарт 20", "Россия", "7886", "Классическая" },
                    { 18, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 элит 20", "Россия", "9858", "Классическая" },
                    { 16, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-7806 стандарт", "Россия", "9507", "ЧИСТОЕ ПОЛЕ" },
                    { 34, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6009 элит 2020", "Венгрия", "9879", "ЧИСТОЕ ПОЛЕ" },
                    { 1, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-95 Элит", "Россия", "10733", "Классическая" },
                    { 2, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-95 стандарт", "Россия", "8401", "Классическая" },
                    { 3, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-26752 элит", "Россия", "13647", "CУМО" },
                    { 4, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-26752 стандарт", "Россия", "9419", "CУМО" },
                    { 5, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-496 элит", "Россия", "14413", "CУМО" },
                    { 6, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-496 стандарт", "Россия", "9660", "CУМО" },
                    { 7, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-498 элит", "Россия", "14413", "CУМО" },
                    { 8, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-498 стандарт", "Россия", "9660", "CУМО" },
                    { 9, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-8003 элит", "Россия", "14413", "CУМО" },
                    { 10, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-8003 стандарт", "Россия", "9660", "CУМО" },
                    { 11, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-8003 стандарт 1 мелк", "Россия", "5660", "CУМО" },
                    { 12, "Гибрид подсолнечника (урожай 2021 года) НС", true, "Римисол элит", "Россия", "13647", "ЧИСТОЕ ПОЛЕ" },
                    { 13, "Гибрид подсолнечника (урожай 2021 года) НС", true, "Римисол стандарт", "Россия", "9507", "ЧИСТОЕ ПОЛЕ" },
                    { 14, "Гибрид подсолнечника (урожай 2021 года) НС", true, "Римисол стандарт 1 мелк", "Россия", "5660", "ЧИСТОЕ ПОЛЕ" },
                    { 15, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-7806 элит", "Россия", "13647", "ЧИСТОЕ ПОЛЕ" },
                    { 17, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 элит 19", "Россия", "8761", "Классическая" },
                    { 35, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6009 элит 18", "Россия", "8233", "ЧИСТОЕ ПОЛЕ" }
                });

            migrationBuilder.InsertData(
                table: "MembraneConfigurations",
                columns: new[] { "Id", "Color", "Length", "MembraneId", "Price", "Type", "Width" },
                values: new object[,]
                {
                    { 1, "Черный", 50, 1, "14370", "type 150", 14 },
                    { 2, "Черный", 50, 2, "13014", "type 150", 12 },
                    { 3, "Черный", 50, 2, "15186", "type 150", 14 },
                    { 4, "Черный", 50, 2, "17922", "type 150", 16 },
                    { 5, "Черный", 50, 2, "22692", "type 150", 18 },
                    { 6, "Черно-белый", 50, 2, "17460", "type 150", 14 },
                    { 7, "Черно-белый", 50, 2, "21540", "type 150", 16 },
                    { 8, "Черно-белый", 50, 2, "29268", "type 150", 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MembraneConfigurations_MembraneId",
                table: "MembraneConfigurations",
                column: "MembraneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MembraneConfigurations");

            migrationBuilder.DropTable(
                name: "SunflowerSeeds");

            migrationBuilder.DropTable(
                name: "SunFlowerViewModels");

            migrationBuilder.DropTable(
                name: "Membranes");
        }
    }
}
