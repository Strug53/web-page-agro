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
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membranes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpringSeeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpringSeeds", x => x.Id);
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
                name: "Szrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfProduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Analog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consumption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szrs", x => x.Id);
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
                columns: new[] { "Id", "Color", "Description", "IsVisible", "Lenght", "Name", "Price", "Type", "Width" },
                values: new object[,]
                {
                    { 1, "Черная", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", true, 50, "Плёнка Silоfolie strong", "10092", "type 150", 10 },
                    { 2, "Черная", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", true, 50, "Плёнка Silоfolie", "12414", "type 150", 10 }
                });

            migrationBuilder.InsertData(
                table: "SpringSeeds",
                columns: new[] { "Id", "Category", "IsVisible", "Name", "Price" },
                values: new object[,]
                {
                    { 28, "Гибриды кукурузы", true, "Краснодарский 194 МВ Раннеспелый 90-99/190", "55 р/кг" },
                    { 27, "Сорта подсолнечника", true, "Персей Супер Элита Высокомасличный Раннеспелый", "200 р/кг" },
                    { 26, "Сорта подсолнечника", true, "Персей ЭС Высокомасличный Раннеспелый", "150 р/кг" },
                    { 25, "Сорта подсолнечника", true, "Казачий Высокомасличный Раннеспелый", "120 р/кг" },
                    { 24, "Сорта подсолнечника", true, "Енисей Высокомасличный Ультраскороспелый", "100 р/кг" },
                    { 23, "Соя", true, "Виктория ЭС", "85 р/кг" },
                    { 21, "Ячмень яровой", true, "Владимир ЭС", "28 р/кг" },
                    { 20, "Ячмень яровой", true, "Надежный ЭС", "28 р/кг" },
                    { 19, "Ячмень яровой", true, "Нур ЭС", "28 р/кг" },
                    { 18, "Ячмень яровой", true, "Космос ЭС", "30 р/кг" },
                    { 17, "Лен масличный", true, "ЛМ-98 ЭС", "160 р/кг" },
                    { 16, "Пшеница яровая", true, "Радмира ЭС", "28 р/кг" },
                    { 15, "Пшеница яровая", true, "Ласка ЭС", "28 р/кг" },
                    { 22, "Овес яровой", true, "Кентер ЭС", "27 р/кг" },
                    { 13, "Пшеница яровая", true, "Курьер ЭС", "28 р/кг" },
                    { 14, "Пшеница яровая", true, "Ладья ЭС", "28 р/кг" },
                    { 1, "Ячмень", true, "Вакула ЭС", "29 р/кг" },
                    { 2, "Ячмень", true, "Вакула PC1", "25 р/кг" },
                    { 3, "Ячмень", true, "Приазовский 9 РС1", "25 р/кг" },
                    { 5, "Ячмень", true, "Космос ЭС", "29 р/кг" },
                    { 6, "Овес", true, "Скакун ЭС", "29 р/кг" },
                    { 4, "Ячмень", true, "Щедрый ЭС", "29 р/кг" },
                    { 7, "Горох", true, "Фокор ЭС", "42 р/кг" },
                    { 8, "Горох", true, "Софья ЭС", "44 р/кг" },
                    { 9, "Гречиха", true, "Девятка ЭС", "90 р/кг" },
                    { 10, "Гречиха", true, "Темп ЭС", "90 р/кг" },
                    { 11, "Пшеница яровая", true, "Дарья ЭС", "30 р/кг" },
                    { 12, "Пшеница яровая", true, "Злата ЭС", "28 р/кг" }
                });

            migrationBuilder.InsertData(
                table: "SunflowerSeeds",
                columns: new[] { "Id", "Category", "IsVisible", "Name", "PlaceOfProduction", "Price", "Technology" },
                values: new object[,]
                {
                    { 26, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-26752 элит 19", "Россия", "9858", "Классическая" },
                    { 21, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6013 элит 19", "Россия", "7886", "Классическая" },
                    { 22, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Ягуар элит 19", "Россия", "9858", "Классическая" },
                    { 23, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Ягуар станд 19", "Россия", "7886", "Классическая" },
                    { 24, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Аламо элит 20", "Россия", "9858", "Классическая" },
                    { 20, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 стандарт 1 мелк 20", "Россия", "5695", "Классическая" },
                    { 27, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-26752 стандарт 19", "Россия", "7886", "Классическая" },
                    { 34, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6009 элит 2020", "Венгрия", "9879", "ЧИСТОЕ ПОЛЕ" },
                    { 29, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6006 стандарт 19", "Россия", "8761", "СУМО" },
                    { 30, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 496 элит 20", "Венгрия", "12047", "СУМО" },
                    { 31, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 496 элит 19", "Россия", "11172", "СУМО" },
                    { 32, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 496 стандарт 19", "Россия", "8761", "СУМО" }
                });

            migrationBuilder.InsertData(
                table: "SunflowerSeeds",
                columns: new[] { "Id", "Category", "IsVisible", "Name", "PlaceOfProduction", "Price", "Technology" },
                values: new object[,]
                {
                    { 33, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 498 стандарт 20", "Россия", "9419", "СУМО" },
                    { 35, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6009 элит 18", "Россия", "8233", "ЧИСТОЕ ПОЛЕ" },
                    { 19, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 стандарт 20", "Россия", "7886", "Классическая" },
                    { 28, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС Х 6006 элит 19", "Россия", "11172", "СУМО" },
                    { 18, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 элит 20", "Россия", "9858", "Классическая" },
                    { 25, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "Аламо стандарт 20", "Россия", "7886", "Классическая" },
                    { 16, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-7806 стандарт", "Россия", "9507", "ЧИСТОЕ ПОЛЕ" },
                    { 17, "Гибрид подсолнечника (урожай  2019- 2020 года) НС", true, "НС-Х-6011 элит 19", "Россия", "8761", "Классическая" },
                    { 1, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-95 Элит", "Россия", "10733", "Классическая" },
                    { 2, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-95 стандарт", "Россия", "8401", "Классическая" },
                    { 3, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-26752 элит", "Россия", "13647", "CУМО" },
                    { 4, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-26752 стандарт", "Россия", "9419", "CУМО" },
                    { 6, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-496 стандарт", "Россия", "9660", "CУМО" },
                    { 7, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-498 элит", "Россия", "14413", "CУМО" },
                    { 8, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-498 стандарт", "Россия", "9660", "CУМО" },
                    { 5, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-496 элит", "Россия", "14413", "CУМО" },
                    { 10, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-8003 стандарт", "Россия", "9660", "CУМО" },
                    { 11, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-8003 стандарт 1 мелк", "Россия", "5660", "CУМО" },
                    { 12, "Гибрид подсолнечника (урожай 2021 года) НС", true, "Римисол элит", "Россия", "13647", "ЧИСТОЕ ПОЛЕ" },
                    { 13, "Гибрид подсолнечника (урожай 2021 года) НС", true, "Римисол стандарт", "Россия", "9507", "ЧИСТОЕ ПОЛЕ" },
                    { 14, "Гибрид подсолнечника (урожай 2021 года) НС", true, "Римисол стандарт 1 мелк", "Россия", "5660", "ЧИСТОЕ ПОЛЕ" },
                    { 15, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-7806 элит", "Россия", "13647", "ЧИСТОЕ ПОЛЕ" },
                    { 9, "Гибрид подсолнечника (урожай 2021 года) НС", true, "НС-Х-8003 элит", "Россия", "14413", "CУМО" }
                });

            migrationBuilder.InsertData(
                table: "Szrs",
                columns: new[] { "Id", "Analog", "Category", "Consumption", "Dv", "IsVisible", "Manufacturer", "Name", "PlaceOfProduction", "Price" },
                values: new object[,]
                {
                    { 24, "Титус, СТС", "Гербициды", "0,03-0,05", "250 г/кг римсульфурона", true, "Форвард", "Римус, ВДГ", "Китай", "15000" },
                    { 31, "", "Инсектициды", "0,5-1", "500г/л хлорпирифос + 50г/л ци-перметрин", true, "Гарант Оптима", "Шаман, КЭ", "Венгрия", "2000" },
                    { 25, "Хармони, СТС", "Гербициды", "0,006-0,025", "750 г/кг тифенсульфурон-метила", true, "РосАгроХим", "Тифи ВДГ", "Китай", "19500" },
                    { 26, "", "Гербициды", "0,006-0,025", "450 имазетапира + 150 хлоримурон-этила", true, "Август", "Фабиан, ВДГ", "Китай", "19500" },
                    { 27, "Пума 100", "Гербициды", "0,4-0,9", "100 г/л феноксапроп-П-этила + 27 г/л антидота клоквинтосет-мексила", true, "Гарант Оптима", "Ягуар Супер 100, КЭ ", "Венгрия", "2000" },
                    { 28, "Фастак", "Инсектициды", "0,1-0,15", "100 г/л альфа-циперметрина", true, "АХТ", "Атрикс, КЭ", "Китай", "1400" },
                    { 29, "Фастак", "Инсектициды", "0,1-0,15", "100 г/л альфа-циперметрина", true, "АХТ", "Атрикс, КЭ", "Китай", "1400" },
                    { 30, "", "Инсектициды", "0,04-0,12", "300 г/л имидаклоприда + 100 г/л лямбда-цигалотрина", true, "АХТ", "Канонир ДУО, ВРК", "Китай", "5200" },
                    { 32, "", "Фунгициды", "0,5", "500 г/л карбендозима", true, "АХТ", "Аксиома, КС", "Китай", "1500" },
                    { 40, "", "Протравители", "0,4-0,5", "60 г/л тебуконазола +80 г/л  тиа-бендазола +60 г/л имазалила", true, "РосАгроХим", "Стингер Трио, КС", "Китай", "2800" },
                    { 34, "", "Фунгициды", "0,4-0,8", "224г/л спироксамин + 148г/л тебуконазол + 53г/л протиоконазол", true, "Байер", "Солигор, КЭ", "", "2930" },
                    { 35, "Альто Супер", "Фунгициды", "0,4-0,5", "250 г/л пропиконазола + 80г/л ци-проконазола", true, "Гарант Оптима", "Виртуоз, КЭ", "Китай", "4000" },
                    { 36, "Альто Супер", "Фунгициды", "0,4-0,5", "250 г/л пропиконазола + 80г/л ци-проконазола", true, "Гарант Оптима", "Виртуоз, КЭ", "Китай", "4000" },
                    { 37, "Альто Супер", "Фунгициды", "0,4-0,5", "250 г/л пропиконазола + 80г/л ци-проконазола", true, "АХТ", "Фунгисил, КЭ", "Китай", "3200" },
                    { 38, "", "Протравители", "0,5-0,8", "92г/л дифеноконазол  + 23г/л ме-феноксам ", true, "Сингента", "Дивиденд Экстрим, КС", "", "3100" },
                    { 39, "Круйзер", "Протравители", "0,5-1", "350 г/л тиаметоксам ", true, "РосАгроХим", "Тиара, КС", "Китай", "3500" },
                    { 23, "Экспресс", "Гербициды", "0,015-0,05", "750 г/кг трибенурон-метила", true, "АХТ", "Прометей, ВДГ ", "Венгрия", "15000" },
                    { 41, "", "Протравители", "0,2-0,3", "100г/лазоксистробин + 120г/л те-буконазол + 40г/л ципроконазол", true, "Агрохим 21", "Триагро, КС", "Китай", "3900" },
                    { 42, "", "Протравители", "0,2-0,25", "60 г/л тиабендазол + 60 г/л тебу-коназол + 40 г/л имазалил", true, "Гарант Оптима", "Тритон ,КС", "Китай", "3500" }
                });

            migrationBuilder.InsertData(
                table: "Szrs",
                columns: new[] { "Id", "Analog", "Category", "Consumption", "Dv", "IsVisible", "Manufacturer", "Name", "PlaceOfProduction", "Price" },
                values: new object[,]
                {
                    { 33, "", "Фунгициды", "0,3-1,5", "500 г/л карбендозима", true, "РосАгроХим", "Дерозал Евро, КС", "Китай", "1500" },
                    { 22, "Бетанал Экс-перт", "Гербициды", "1-3", "112 г/л этофумезат + 91 г/л фенмедифам + 71 г/л десмедифам", true, "АХТ", "Синбетан Эксперт ОФ, КЭ", "Китай", "2000" },
                    { 14, "Инновейт", "Гербициды", "1-1,5", "40 г/л никосульфурона", true, "АХТ", "Милафорт, КЭ ", "Китай", "1300" },
                    { 20, "Зеллек-супер", "Гербициды", "0,5-1", "104 г/л галоксифоп-Р-метила", true, "Гарант Оптима", "Сокол, КЭ", "Китай", "3000" },
                    { 43, "Реглон Супер", "Протравители", "2", "150 г/л диквата (дибромид)", true, "РосАгроХим", "Десикант Экспертоф, ВР", "Китай", "1500" },
                    { 1, "", "Гербициды", "0.4-0.6", "300 г/л 2,4-Д этилгексилового эфира и 6,25 г/л флорасулама", true, "ФМРус", "Астерикс,СЭ", "Китай", "1500" },
                    { 2, "", "Гербициды", "0.4-0.6", "300 г/л 2,4-Д этилгексилового эфира и 6,25 г/л флорасулама", true, "АХТ", "Дисулам,СЭ", "Китай", "1500" },
                    { 3, "", "Гербициды", "0.4-0.6", "300 г/л 2,4-Д этилгексилового эфира и 6,25 г/л флорасулама", true, "Агрокорм", "Опричник,СЭ", "Китай", "1500" },
                    { 4, "", "Гербициды", "1.5-4", "480 г/л бентазона", true, "Ипрохим", "Гранбаз, ВР", "", "2400" },
                    { 5, "Гранстар ПРО", "Гербициды", "0,015-0,025", "750 г/кг трибенурон-метила", true, "РосАгроХим", "Грэнери, ВДГ", "Китай", "8500" },
                    { 6, "Гранстар ПРО", "Гербициды", "0,015-0,025", "750 г/кг трибенурон-метила", true, "АХТ", "Гренадер, ВДГ", "Китай", "8500" },
                    { 7, "Гранстар ПРО", "Гербициды", "0,015-0,025", "750 г/кг трибенурон-метила", true, "Ранголи", "Ранголи-Трибенурон, ВДГ", "Китай", "8500" },
                    { 8, "Евро-Лайтинг", "Гербициды", "1-1.2", "33 г/л  имазамокса +15 г/л имаза-пира", true, "Гарант Оптима", "Евро-Ленд, ВРК", "Венгрия", "3000" },
                    { 9, "Евро-Лайтинг", "Гербициды", "1-1.2", "33 г/л  имазамокса +15 г/л имаза-пира", true, "АХТ", "Импекс Дуо, ВРК", "Китай", "3000" },
                    { 10, "Лонтрел Гранд", "Гербициды", "0.12", "750 г/кг клопиралида", true, "РосАгроХим", "Клео, ВДГ", "Китай", "9000" },
                    { 11, "", "Гербициды", "0,22-0,44", "23 г/кг римсульфурон + 92г/кг ни-косульфурон + дикамба в виде диметиламинной соли (550 г/кг в пересчете на кислоту)", true, "Картева", "Кордус Плюс, ВДГ", "Китай", "11787" },
                    { 12, "Карибу", "Гербициды", "0.03", "500 г/кг трифлусульфурон-метила", true, "РосАгроХим", "Малибу, ВДГ", "Россия", "22600" },
                    { 13, "Каллисто", "Гербициды", "0,15-0,25", "480 г/л мезотриона", true, "Союзагрохим", "Мезокорн, КС", "Китай", "8000" },
                    { 15, "Инновейт", "Гербициды", "1-1,5", "40 г/л никосульфурона", true, "Гарант Оптима", "Милена, КЭ", "Венгрия", "1300" },
                    { 16, "Инновейт", "Гербициды", "1-1,5", "40 г/л никосульфурона", true, "ХАМ", "Приоритет, КЭ", "Китай", "1300" },
                    { 17, "", "Гербициды", "0,05-0,1", "750 г/кг никосульфурона", true, "РосАгроХим", "НЭО, ВДГ", "Китай", "16800" },
                    { 18, "Элюмис", "Гербициды", "1,25-2", "75 г / л мезотриона +  30 г / л ни-косульфурона", true, "", "Легенда, МД", "Китай", "2300" },
                    { 19, "Зеллек-супер", "Гербициды", "0,5-1", "104 г/л галоксифоп-Р-метила", true, "АХТ", "Ореол, КЭ", "Китай", "3000" },
                    { 21, "Пивот", "Гербициды", "0,50-0,8", "100 г/л имазетапира", true, "Гарант Оптима", "Серп, ВР", "Венгрия", "2800" },
                    { 44, "Реглон Супер", "Протравители", "2", "150 г/л диквата (дибромид)", true, "АХТ", "Регистан, ВР", "Китай", "1500" }
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
                name: "SpringSeeds");

            migrationBuilder.DropTable(
                name: "SunflowerSeeds");

            migrationBuilder.DropTable(
                name: "Szrs");

            migrationBuilder.DropTable(
                name: "Membranes");
        }
    }
}
