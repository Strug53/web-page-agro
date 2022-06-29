using Microsoft.EntityFrameworkCore;
using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;


namespace agrokorm.Models.Db
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Membrane> Membranes { get; set; }
        public DbSet<SunflowerSeed> SunflowerSeeds { get; set; }
        public DbSet<MembraneConfiguration> MembraneConfigurations { get; set; }
        public DbSet<SunFlowerViewModel> SunFlowerViewModels { get; set; }
        public DbSet<Szr> Szrs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);


            modelbuilder.Entity<Membrane>(builder =>
            { 
                //Membrane
                builder.HasData(new Membrane
                {
                    Id = 1,
                    Name = "Плёнка Silоfolie strong",
                    Color = "Черная",
                    Width = 10,
                    Lenght = 50,
                    Type = "type 150",
                    Price = "10092",
                    IsVisible = true,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a " +
                    "galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap " +
                    "into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
                    "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    
                    MembraneConfigurations = null
                });

                builder.HasData(new Membrane
                {
                    Id = 2,
                    Name = "Плёнка Silоfolie",
                    Color = "Черная",
                    Width = 10,
                    Lenght = 50,
                    Type = "type 150",
                    Price = "12414",
                    IsVisible = true,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a " +
                    "galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap " +
                    "into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
                    "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    
                    MembraneConfigurations = null
                });

                builder.ToTable("Membranes").HasKey(x => x.Id);

                builder.Property(x => x.Id).ValueGeneratedOnAdd();
            }
            );
            //Membrane Configuration
            modelbuilder.Entity<MembraneConfiguration>(membraneBuilder =>
            { 
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 1,
                    Color = "Черный",
                    Width = 14,
                    Length = 50,
                    Type = "type 150",
                    Price = "14370",
                    MembraneId = 1
                });
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 2,
                    Color = "Черный",
                    Width = 12,
                    Length = 50,
                    Type = "type 150",
                    Price = "13014",
                    MembraneId = 2
                });
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 3,
                    Color = "Черный",
                    Width = 14,
                    Length = 50,
                    Type = "type 150",
                    Price = "15186",
                    MembraneId = 2
                });
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 4,
                    Color = "Черный",
                    Width = 16,
                    Length = 50,
                    Type = "type 150",
                    Price = "17922",
                    MembraneId = 2
                });
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 5,
                    Color = "Черный",
                    Width = 18,
                    Length = 50,
                    Type = "type 150",
                    Price = "22692",
                    MembraneId = 2
                });
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 6,
                    Color = "Черно-белый",
                    Width = 14,
                    Length = 50,
                    Type = "type 150",
                    Price = "17460",
                    MembraneId = 2
                });
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 7,
                    Color = "Черно-белый",
                    Width = 16,
                    Length = 50,
                    Type = "type 150",
                    Price = "21540",
                    MembraneId = 2
                });
                membraneBuilder.HasData(new MembraneConfiguration
                {
                    Id = 8,
                    Color = "Черно-белый",
                    Width = 18,
                    Length = 50,
                    Type = "type 150",
                    Price = "29268",
                    MembraneId = 2
                });

                membraneBuilder.ToTable("MembraneConfigurations").HasKey(x => x.Id);

                membraneBuilder.Property(x => x.Id).ValueGeneratedOnAdd();  

            }
            );
            //------------------------------------------------------------------------------------------------------------------------------

            //SeedViewModel
            modelbuilder.Entity<SunFlowerViewModel>(sunflowerbuilder =>
            {
                sunflowerbuilder.HasData(new SunFlowerViewModel()
                {
                    Id = 1,
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. " +
                    "It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. " +
                    "Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, " +
                    "looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, " +
                    "and going through the cites of the word in classical literature, discovered the undoubtable source. " +
                    "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of" +
                    "(The Extremes of Good and Evil) by Cicero, written in 45 BC."

                });
                sunflowerbuilder.ToTable("SunFlowerViewModels").HasKey(x => x.Id);

            }
            );


            //Seed
            modelbuilder.Entity<SunflowerSeed>(seedbuilder =>
            {
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 1,
                    Name = "НС-Х-95 Элит",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "10733",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"
                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 2,
                    Name = "НС-Х-95 стандарт",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "8401",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"
                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 3,
                    Name = "НС-Х-26752 элит",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "13647",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 4,
                    Name = "НС-Х-26752 стандарт",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "9419",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 5,
                    Name = "НС-Х-496 элит",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "14413",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 6,
                    Name = "НС-Х-496 стандарт",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "9660",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 7,
                    Name = "НС-Х-498 элит",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "14413",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 8,
                    Name = "НС-Х-498 стандарт",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "9660",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 9,
                    Name = "НС-Х-8003 элит",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "14413",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 10,
                    Name = "НС-Х-8003 стандарт",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "9660",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 11,
                    Name = "НС-Х-8003 стандарт 1 мелк",
                    PlaceOfProduction = "Россия",
                    Technology = "CУМО",
                    Price = "5660",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 12,
                    Name = "Римисол элит",
                    PlaceOfProduction = "Россия",
                    Technology = "ЧИСТОЕ ПОЛЕ",
                    Price = "13647",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 13,
                    Name = "Римисол стандарт",
                    PlaceOfProduction = "Россия",
                    Technology = "ЧИСТОЕ ПОЛЕ",
                    Price = "9507",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 14,
                    Name = "Римисол стандарт 1 мелк",
                    PlaceOfProduction = "Россия",
                    Technology = "ЧИСТОЕ ПОЛЕ",
                    Price = "5660",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 15,
                    Name = "НС-Х-7806 элит",
                    PlaceOfProduction = "Россия",
                    Technology = "ЧИСТОЕ ПОЛЕ",
                    Price = "13647",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 16,
                    Name = "НС-Х-7806 стандарт",
                    PlaceOfProduction = "Россия",
                    Technology = "ЧИСТОЕ ПОЛЕ",
                    Price = "9507",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай 2021 года) НС"

                });
                //Gybrid sunflower(2019-2020)
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 17,
                    Name = "НС-Х-6011 элит 19",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "8761",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 18,
                    Name = "НС-Х-6011 элит 20",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "9858",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 19,
                    Name = "НС-Х-6011 стандарт 20",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "7886",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 20,
                    Name = "НС-Х-6011 стандарт 1 мелк 20",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "5695",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 21,
                    Name = "НС-Х-6013 элит 19",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "7886",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 22,
                    Name = "Ягуар элит 19",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "9858",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 23,
                    Name = "Ягуар станд 19",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "7886",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 24,
                    Name = "Аламо элит 20",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "9858",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 25,
                    Name = "Аламо стандарт 20",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "7886",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 26,
                    Name = "НС-Х-26752 элит 19",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "9858",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 27,
                    Name = "НС-Х-26752 стандарт 19",
                    PlaceOfProduction = "Россия",
                    Technology = "Классическая",
                    Price = "7886",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 28,
                    Name = "НС Х 6006 элит 19",
                    PlaceOfProduction = "Россия",
                    Technology = "СУМО",
                    Price = "11172",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 29,
                    Name = "НС Х 6006 стандарт 19",
                    PlaceOfProduction = "Россия",
                    Technology = "СУМО",
                    Price = "8761",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 30,
                    Name = "НС Х 496 элит 20",
                    PlaceOfProduction = "Венгрия",
                    Technology = "СУМО",
                    Price = "12047",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 31,
                    Name = "НС Х 496 элит 19",
                    PlaceOfProduction = "Россия",
                    Technology = "СУМО",
                    Price = "11172",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 32,
                    Name = "НС Х 496 стандарт 19",
                    PlaceOfProduction = "Россия",
                    Technology = "СУМО",
                    Price = "8761",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 33,
                    Name = "НС Х 498 стандарт 20",
                    PlaceOfProduction = "Россия",
                    Technology = "СУМО",
                    Price = "9419",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 34,
                    Name = "НС Х 6009 элит 2020",
                    PlaceOfProduction = "Венгрия",
                    Technology = "ЧИСТОЕ ПОЛЕ",
                    Price = "9879",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });
                seedbuilder.HasData(new SunflowerSeed()
                {
                    Id = 35,
                    Name = "НС Х 6009 элит 18",
                    PlaceOfProduction = "Россия",
                    Technology = "ЧИСТОЕ ПОЛЕ",
                    Price = "8233",
                    IsVisible = true,
                    Category = "Гибрид подсолнечника (урожай  2019- 2020 года) НС"

                });








                seedbuilder.ToTable("SunflowerSeeds").HasKey(x => x.Id);

                seedbuilder.Property(x => x.Id).ValueGeneratedOnAdd();

            }
            );

            //-------------------------------------------------------------------------------------------------------------------------------

            //Szr

            modelbuilder.Entity<Szr>(builder =>
            {
                builder.HasData(new Szr()
                {
                    Id = 1,
                    Name = "Астерикс,СЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "ФМРус",
                    Dv = "300 г/л 2,4-Д этилгексилового эфира и " +
                    "6,25 г/л флорасулама",
                    Analog = "",
                    Consumption = "0.4-0.6",
                    Price = "1500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 2,
                    Name = "Дисулам,СЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "300 г/л 2,4-Д этилгексилового эфира и " +
                    "6,25 г/л флорасулама",
                    Analog = "",
                    Consumption = "0.4-0.6",
                    Price = "1500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 3,
                    Name = "Опричник,СЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Агрокорм",
                    Dv = "300 г/л 2,4-Д этилгексилового эфира и " +
                    "6,25 г/л флорасулама",
                    Analog = "",
                    Consumption = "0.4-0.6",
                    Price = "1500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 4,
                    Name = "Гранбаз, ВР",
                    PlaceOfProduction = "",
                    Manufacturer = "Ипрохим",
                    Dv = "480 г/л бентазона",
                    Analog = "",
                    Consumption = "1.5-4",
                    Price = "2400",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 5,
                    Name = "Грэнери, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "750 г/кг трибенурон-метила",
                    Analog = "Гранстар ПРО",
                    Consumption = "0,015-0,025",
                    Price = "8500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 6,
                    Name = "Гренадер, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "750 г/кг трибенурон-метила",
                    Analog = "Гранстар ПРО",
                    Consumption = "0,015-0,025",
                    Price = "8500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 7,
                    Name = "Ранголи-Трибенурон, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Ранголи",
                    Dv = "750 г/кг трибенурон-метила",
                    Analog = "Гранстар ПРО",
                    Consumption = "0,015-0,025",
                    Price = "8500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 8,
                    Name = "Евро-Ленд, ВРК",
                    PlaceOfProduction = "Венгрия",
                    Manufacturer = "Гарант Оптима",
                    Dv = "33 г/л  имазамокса +15 г/л имаза-пира",
                    Analog = "Евро-Лайтинг",
                    Consumption = "1-1.2",
                    Price = "3000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 9,
                    Name = "Импекс Дуо, ВРК",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "33 г/л  имазамокса +15 г/л имаза-пира",
                    Analog = "Евро-Лайтинг",
                    Consumption = "1-1.2",
                    Price = "3000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 10,
                    Name = "Клео, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "750 г/кг клопиралида",
                    Analog = "Лонтрел Гранд",
                    Consumption = "0.12",
                    Price = "9000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 11,
                    Name = "Кордус Плюс, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Картева",
                    Dv = "23 г/кг римсульфурон + 92г/кг ни-косульфурон " +
                    "+ дикамба в виде диметиламинной соли (550 г/кг в пересчете на кислоту)",
                    Analog = "",
                    Consumption = "0,22-0,44",
                    Price = "11787",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 12,
                    Name = "Малибу, ВДГ",
                    PlaceOfProduction = "Россия",
                    Manufacturer = "РосАгроХим",
                    Dv = "500 г/кг трифлусульфурон-метила",
                    Analog = "Карибу",
                    Consumption = "0.03",
                    Price = "22600",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 13,
                    Name = "Мезокорн, КС",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Союзагрохим",
                    Dv = "480 г/л мезотриона",
                    Analog = "Каллисто",
                    Consumption = "0,15-0,25",
                    Price = "8000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 14,
                    Name = "Милафорт, КЭ ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "40 г/л никосульфурона",
                    Analog = "Инновейт",
                    Consumption = "1-1,5",
                    Price = "1300",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 15,
                    Name = "Милена, КЭ",
                    PlaceOfProduction = "Венгрия",
                    Manufacturer = "Гарант Оптима",
                    Dv = "40 г/л никосульфурона",
                    Analog = "Инновейт",
                    Consumption = "1-1,5",
                    Price = "1300",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 16,
                    Name = "Приоритет, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "ХАМ",
                    Dv = "40 г/л никосульфурона",
                    Analog = "Инновейт",
                    Consumption = "1-1,5",
                    Price = "1300",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 17,
                    Name = "НЭО, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "750 г/кг никосульфурона",
                    Analog = "",
                    Consumption = "0,05-0,1",
                    Price = "16800",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 18,
                    Name = "Легенда, МД",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "",
                    Dv = "75 г / л мезотриона +  30 г / л ни-косульфурона",
                    Analog = "Элюмис",
                    Consumption = "1,25-2",
                    Price = "2300",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 19,
                    Name = "Ореол, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "104 г/л галоксифоп-Р-метила",
                    Analog = "Зеллек-супер",
                    Consumption = "0,5-1",
                    Price = "3000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 20,
                    Name = "Сокол, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Гарант Оптима",
                    Dv = "104 г/л галоксифоп-Р-метила",
                    Analog = "Зеллек-супер",
                    Consumption = "0,5-1",
                    Price = "3000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 21,
                    Name = "Серп, ВР",
                    PlaceOfProduction = "Венгрия",
                    Manufacturer = "Гарант Оптима",
                    Dv = "100 г/л имазетапира",
                    Analog = "Пивот",
                    Consumption = "0,50-0,8",
                    Price = "2800",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 22,
                    Name = "Синбетан Эксперт ОФ, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "112 г/л этофумезат + 91 г/л фенмедифам + 71 г/л десмедифам",
                    Analog = "Бетанал Экс-перт",
                    Consumption = "1-3",
                    Price = "2000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 23,
                    Name = "Прометей, ВДГ ",
                    PlaceOfProduction = "Венгрия",
                    Manufacturer = "АХТ",
                    Dv = "750 г/кг трибенурон-метила",
                    Analog = "Экспресс",
                    Consumption = "0,015-0,05",
                    Price = "15000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 24,
                    Name = "Римус, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Форвард",
                    Dv = "250 г/кг римсульфурона",
                    Analog = "Титус, СТС",
                    Consumption = "0,03-0,05",
                    Price = "15000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 25,
                    Name = "Тифи ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "750 г/кг тифенсульфурон-метила",
                    Analog = "Хармони, СТС",
                    Consumption = "0,006-0,025",
                    Price = "19500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 26,
                    Name = "Фабиан, ВДГ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Август",
                    Dv = "450 имазетапира + 150 хлоримурон-этила",
                    Analog = "",
                    Consumption = "0,006-0,025",
                    Price = "19500",
                    Category = "Гербициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 27,
                    Name = "Ягуар Супер 100, КЭ ",
                    PlaceOfProduction = "Венгрия",
                    Manufacturer = "Гарант Оптима",
                    Dv = "100 г/л феноксапроп-П-этила + 27 г/л антидота клоквинтосет-мексила",
                    Analog = "Пума 100",
                    Consumption = "0,4-0,9",
                    Price = "2000",
                    Category = "Гербициды",
                    IsVisible = true
                });
                //---
                builder.HasData(new Szr()
                {
                    Id = 28,
                    Name = "Атрикс, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "100 г/л альфа-циперметрина",
                    Analog = "Фастак",
                    Consumption = "0,1-0,15",
                    Price = "1400",
                    Category = "Инсектициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 29,
                    Name = "Атрикс, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "100 г/л альфа-циперметрина",
                    Analog = "Фастак",
                    Consumption = "0,1-0,15",
                    Price = "1400",
                    Category = "Инсектициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 30,
                    Name = "Канонир ДУО, ВРК",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "300 г/л имидаклоприда + 100 г/л лямбда-цигалотрина",
                    Analog = "",
                    Consumption = "0,04-0,12",
                    Price = "5200",
                    Category = "Инсектициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 31,
                    Name = "Шаман, КЭ",
                    PlaceOfProduction = "Венгрия",
                    Manufacturer = "Гарант Оптима",
                    Dv = "500г/л хлорпирифос + 50г/л ци-перметрин",
                    Analog = "",
                    Consumption = "0,5-1",
                    Price = "2000",
                    Category = "Инсектициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 32,
                    Name = "Аксиома, КС",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "500 г/л карбендозима",
                    Analog = "",
                    Consumption = "0,5",
                    Price = "1500",
                    Category = "Фунгициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 33,
                    Name = "Дерозал Евро, КС",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "500 г/л карбендозима",
                    Analog = "",
                    Consumption = "0,3-1,5",
                    Price = "1500",
                    Category = "Фунгициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 34,
                    Name = "Солигор, КЭ",
                    PlaceOfProduction = "",
                    Manufacturer = "Байер",
                    Dv = "224г/л спироксамин + 148г/л тебуконазол + 53г/л протиоконазол",
                    Analog = "",
                    Consumption = "0,4-0,8",
                    Price = "2930",
                    Category = "Фунгициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 35,
                    Name = "Виртуоз, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Гарант Оптима",
                    Dv = "250 г/л пропиконазола + 80г/л ци-проконазола",
                    Analog = "Альто Супер",
                    Consumption = "0,4-0,5",
                    Price = "4000",
                    Category = "Фунгициды",
                    IsVisible = true
                }); 
                builder.HasData(new Szr()
                {
                    Id = 36,
                    Name = "Виртуоз, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Гарант Оптима",
                    Dv = "250 г/л пропиконазола + 80г/л ци-проконазола",
                    Analog = "Альто Супер",
                    Consumption = "0,4-0,5",
                    Price = "4000",
                    Category = "Фунгициды",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 37,
                    Name = "Фунгисил, КЭ",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "250 г/л пропиконазола + 80г/л ци-проконазола",
                    Analog = "Альто Супер",
                    Consumption = "0,4-0,5",
                    Price = "3200",
                    Category = "Фунгициды",
                    IsVisible = true
                });
                //----
                builder.HasData(new Szr()
                {
                    Id = 38,
                    Name = "Дивиденд Экстрим, КС",
                    PlaceOfProduction = "",
                    Manufacturer = "Сингента",
                    Dv = "92г/л дифеноконазол  + 23г/л ме-феноксам ",
                    Analog = "",
                    Consumption = "0,5-0,8",
                    Price = "3100",
                    Category = "Протравители",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 39,
                    Name = "Тиара, КС",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "350 г/л тиаметоксам ",
                    Analog = "Круйзер",
                    Consumption = "0,5-1",
                    Price = "3500",
                    Category = "Протравители",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 40,
                    Name = "Стингер Трио, КС",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "60 г/л тебуконазола +80 г/л  тиа-бендазола +60 г/л имазалила",
                    Analog = "",
                    Consumption = "0,4-0,5",
                    Price = "2800",
                    Category = "Протравители",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 41,
                    Name = "Триагро, КС",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Агрохим 21",
                    Dv = "100г/лазоксистробин + 120г/л те-буконазол + 40г/л ципроконазол",
                    Analog = "",
                    Consumption = "0,2-0,3",
                    Price = "3900",
                    Category = "Протравители",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 42,
                    Name = "Тритон ,КС",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "Гарант Оптима",
                    Dv = "60 г/л тиабендазол + 60 г/л тебу-коназол + 40 г/л имазалил",
                    Analog = "",
                    Consumption = "0,2-0,25",
                    Price = "3500",
                    Category = "Протравители",
                    IsVisible = true
                });
                //----
                builder.HasData(new Szr()
                {
                    Id = 43,
                    Name = "Десикант Экспертоф, ВР",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "РосАгроХим",
                    Dv = "150 г/л диквата (дибромид)",
                    Analog = "Реглон Супер",
                    Consumption = "2",
                    Price = "1500",
                    Category = "Протравители",
                    IsVisible = true
                });
                builder.HasData(new Szr()
                {
                    Id = 44,
                    Name = "Регистан, ВР",
                    PlaceOfProduction = "Китай",
                    Manufacturer = "АХТ",
                    Dv = "150 г/л диквата (дибромид)",
                    Analog = "Реглон Супер",
                    Consumption = "2",
                    Price = "1500",
                    Category = "Протравители",
                    IsVisible = true
                });

                builder.ToTable("Szrs").HasKey(x => x.Id);
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
            });
        }

       
    }
}
