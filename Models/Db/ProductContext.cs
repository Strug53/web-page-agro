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
        public DbSet<SpringSeed> SpringSeeds { get; set; }
        public DbSet<Szr> Szrs { get; set; }
        public DbSet<GrassSeed> GrassSeeds { get; set; }
        public DbSet<Legumes> Legumes { get; set; }
        public DbSet<GrassMixture> GrassMixtures { get; set; }

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

            modelbuilder.Entity<SpringSeed>(seedbuilder =>
            {

                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 1,
                    Name = "Вакула ЭС",
                    Price = "29 р/кг",
                    Category = "Ячмень",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 2,
                    Name = "Вакула PC1",
                    Price = "25 р/кг",
                    Category = "Ячмень",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 3,
                    Name = "Приазовский 9 РС1",
                    Price = "25 р/кг",
                    Category = "Ячмень",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 4,
                    Name = "Щедрый ЭС",
                    Price = "29 р/кг",
                    Category = "Ячмень",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 5,
                    Name = "Космос ЭС",
                    Price = "29 р/кг",
                    Category = "Ячмень",
                    IsVisible = true
                });
                //----------


                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 6,
                    Name = "Скакун ЭС",
                    Price = "29 р/кг",
                    Category = "Овес",
                    IsVisible = true
                });
                //--------


                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 7,
                    Name = "Фокор ЭС",
                    Price = "42 р/кг",
                    Category = "Горох",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 8,
                    Name = "Софья ЭС",
                    Price = "44 р/кг",
                    Category = "Горох",
                    IsVisible = true
                });
                //------------


                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 9,
                    Name = "Девятка ЭС",
                    Price = "90 р/кг",
                    Category = "Гречиха",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 10,
                    Name = "Темп ЭС",
                    Price = "90 р/кг",
                    Category = "Гречиха",
                    IsVisible = true
                });
                //-----------


                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 11,
                    Name = "Дарья ЭС",
                    Price = "30 р/кг",
                    Category = "Пшеница яровая",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 12,
                    Name = "Злата ЭС",
                    Price = "28 р/кг",
                    Category = "Пшеница яровая",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 13,
                    Name = "Курьер ЭС",
                    Price = "28 р/кг",
                    Category = "Пшеница яровая",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 14,
                    Name = "Ладья ЭС",
                    Price = "28 р/кг",
                    Category = "Пшеница яровая",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 15,
                    Name = "Ласка ЭС",
                    Price = "28 р/кг",
                    Category = "Пшеница яровая",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 16,
                    Name = "Радмира ЭС",
                    Price = "28 р/кг",
                    Category = "Пшеница яровая",
                    IsVisible = true
                });
                //------------


                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 17,
                    Name = "ЛМ-98 ЭС",
                    Price = "160 р/кг",
                    Category = "Лен масличный",
                    IsVisible = true
                });

                //-----


                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 18,
                    Name = "Космос ЭС",
                    Price = "30 р/кг",
                    Category = "Ячмень яровой",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 19,
                    Name = "Нур ЭС",
                    Price = "28 р/кг",
                    Category = "Ячмень яровой",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 20,
                    Name = "Надежный ЭС",
                    Price = "28 р/кг",
                    Category = "Ячмень яровой",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 21,
                    Name = "Владимир ЭС",
                    Price = "28 р/кг",
                    Category = "Ячмень яровой",
                    IsVisible = true
                });

                //---------



                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 22,
                    Name = "Кентер ЭС",
                    Price = "27 р/кг",
                    Category = "Овес яровой",
                    IsVisible = true
                });


                //------


                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 23,
                    Name = "Виктория ЭС",
                    Price = "85 р/кг",
                    Category = "Соя",
                    IsVisible = true
                });

                //------


                //sunflower

                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 24,
                    Name = "Енисей Высокомасличный Ультраскороспелый",
                    Price = "100 р/кг",
                    Category = "Сорта подсолнечника",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 25,
                    Name = "Казачий Высокомасличный Раннеспелый",
                    Price = "120 р/кг",
                    Category = "Сорта подсолнечника",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 26,
                    Name = "Персей ЭС Высокомасличный Раннеспелый",
                    Price = "150 р/кг",
                    Category = "Сорта подсолнечника",
                    IsVisible = true
                });
                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 27,
                    Name = "Персей Супер Элита Высокомасличный Раннеспелый",
                    Price = "200 р/кг",
                    Category = "Сорта подсолнечника",
                    IsVisible = true
                });

                //corn

                seedbuilder.HasData(new SpringSeed()
                {
                    Id = 28,
                    Name = "Краснодарский 194 МВ Раннеспелый 90-99/190",
                    Price = "55 р/кг",
                    Category = "Гибриды кукурузы",
                    IsVisible = true
                });


                seedbuilder.ToTable("SpringSeeds").HasKey(x => x.Id);
                seedbuilder.Property(x => x.Id).ValueGeneratedOnAdd();

            });

            modelbuilder.Entity<Legumes>(seedbuilder =>
            {
                seedbuilder.HasData(new Legumes()
                {
                    Id = 1,
                    Name = "Вика яровая",
                    Variety = "Никольская РС-2",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "35",
                    IsVisible=true
                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 2,
                    Name = "Горох посевной",
                    Variety = "Фараон РС-1, Софья ЭС",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "35, 40",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 3,
                    Name = "Горох",
                    Variety = "Усатый кормовой РС-2",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "35, 40",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 4,
                    Name = "Горох",
                    Variety = "Пелюшка РСт",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "35",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 5,
                    Name = "Гречиха",
                    Variety = "Темп ЭС",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 6,
                    Name = "Вика / Овес 30/70",
                    Variety = "Никольская РС-2/Скакун РС-1",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "23",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 7,
                    Name = "Горох/Овес 30/70",
                    Variety = "",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "23",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 8,
                    Name = "Горох/Овес 40/60",
                    Variety = "",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "24",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 9,
                    Name = "Вика/Горох/Овес 25/20/55",
                    Variety = "",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "25",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 10,
                    Name = "Овес",
                    Variety = "Скакун РС-1, ЭС",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "17, 24",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 11,
                    Name = "Горчица белая",
                    Variety = "Рапсодия РСт",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "40",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 12,
                    Name = "Соя",
                    Variety = "Мезенка РС-1",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "",
                    IsVisible = true

                });
                seedbuilder.HasData(new Legumes()
                {
                    Id = 13,
                    Name = "Пшеница яровая",
                    Variety = "Дарья РС-1",
                    Category = "Зерновые и зернобобовые культуры",
                    Price = "25",
                    IsVisible = true

                });

            });

            modelbuilder.Entity<GrassSeed>(seedbuilder =>
            {

                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 1,
                    Name = "Люцерна синяя",
                    Variety = "Сирена ЭС, Артемида ЭС, Верко РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "450",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 2,
                    Name = "Клевер луговой",
                    Variety = "Трио РС-1, ЭС",
                    Category = "Однолетние и многолетние травы",
                    Price = "180, 240",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 3,
                    Name = "Фестулолиум",
                    Variety = "Вик 90 РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "190",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 4,
                    Name = "Фацелия",
                    Variety = "",
                    Category = "Однолетние и многолетние травы",
                    Price = "220",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 5,
                    Name = "Эспарцет",
                    Variety = "Песчаный 1251 РС-3",
                    Category = "Однолетние и многолетние травы",
                    Price = "55",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 6,
                    Name = "Пайза",
                    Variety = "Красава ЭС",
                    Category = "Однолетние и многолетние травы",
                    Price = "50",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 7,
                    Name = "Кострец безостый",
                    Variety = "Сибниисхоз 189 РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "220",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 8,
                    Name = "Райграс пастбищный",
                    Variety = "Вик 66 РС-2",
                    Category = "Однолетние и многолетние травы",
                    Price = "170",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 9,
                    Name = "Райграс однолетний",
                    Variety = "Рапид",
                    Category = "Однолетние и многолетние травы",
                    Price = "120",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 10,
                    Name = "Овсяница луговая",
                    Variety = "Свердловская 37 РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "170",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 11,
                    Name = "Овсяница тростниковая",
                    Variety = "Липальма",
                    Category = "Однолетние и многолетние травы",
                    Price = "190",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 12,
                    Name = "Овсяница красная",
                    Variety = "Бореал РС-2",
                    Category = "Однолетние и многолетние травы",
                    Price = "280",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 13,
                    Name = "Тимофеевка луговая",
                    Variety = "Ленинградская 204",
                    Category = "Однолетние и многолетние травы",
                    Price = "170",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 14,
                    Name = "Тимофеевка",
                    Variety = "Псковская местная РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "170",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 15,
                    Name = "Клевер полз. Белый",
                    Variety = "РЕВЕНДЕЛ",
                    Category = "Однолетние и многолетние травы",
                    Price = "750",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 16,
                    Name = "Мятлик луговой",
                    Variety = "БАЛИН РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "600",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 17,
                    Name = "Ежа сборная",
                    Variety = "Вик 61 РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "180",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 18,
                    Name = "Суданская трава",
                    Variety = "Кинельская 100 РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "50",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 19,
                    Name = "Лядвенец рогатый",
                    Variety = "Солнышко РС-1",
                    Category = "Однолетние и многолетние травы",
                    Price = "договраня",
                    IsVisible = true

                });
                seedbuilder.HasData(new GrassSeed()
                {
                    Id = 20,
                    Name = "Пырей ползучий",
                    Variety = "",
                    Category = "Однолетние и многолетние травы",
                    Price = "140",
                    IsVisible = true

                });

            });



            //Travosmesi

            modelbuilder.Entity<GrassMixture>(grassmixturebuilder =>
            {
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 1,
                    Name = "Травосмесь №1 (универсальная)",
                    Сomposition = "30%Райграс пастбищный 45% Овсяница луговая 25% Тимофеевка луговая",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "165 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 2,
                    Name = "Травосмесь №2 (для пастбищ и сенокосов)",
                    Сomposition = "20% Тимофеевка луговая 40% Райграс пастбищный 15% Овсяница луговая 10% Ежа сборная 10% Клевер ползучий 5% Мятлик луговой",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "250 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 3,
                    Name = "Травосмесь №3 (для заготовки кормов)",
                    Сomposition = "30% Тимофеевка луговая 30% Райграс пастбищный 30% Овсяница луговая 10% Клевер красный",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "170 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 4,
                    Name = "Травосмесь №4 (для заготовки кормов)",
                    Сomposition = "30% Люцерна 15 % Клевер красный 25 % Овсяница луговая 15 % Райграс пастбищный 15 % Фестулолиум",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "260 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 5,
                    Name = "Травосмесь №5 (для заготовки кормов)",
                    Сomposition = "30% Люцерна 20 % Клевер красный 30 % Тимофеевка луговая 20 % Овсяница луговая",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "255 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 6,
                    Name = "Травосмесь №6 (для заготовки кормов)",
                    Сomposition = "20% Люцерна 10% Клевер красный 20% Фестулолиум 20% Овсяница луговая 30% Тимофеевка",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "230 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 7,
                    Name = "Травосмесь №7 (для сенокосов)",
                    Сomposition = "50% Кострец б/о 20% Тимофеевка луговая 15% Овсяница луговая 15% Райграс пастбищный",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "190 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 8,
                    Name = "Травосмесь №8 (для сенокосов)",
                    Сomposition = "20% Овсяница луговая 20% Тимофеевка луговая 20% Райграс пастбищный 20% Фестулолиум 20% Райграс однолетний",
                    Category = "Изготавливаем пастбищные и укосные травосмеси на заказ по Вашей заявке и рецептуре (Норма высева 25- 30 кг на 1 Га)",
                    Price = "150 руб/кг",
                    IsVisible = true
                });
                //--------
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 9,
                    Name = "Травосмесь «Питательная»:",
                    Сomposition = "Райграс пастбищный — 35% Тимофеевка луговая — 20% Люцерна изменчивая — 20% Мятлик луговой — 15% Фестулолиум — 10%",
                    Description = "Смесь семян многолетних кормовых трав (злаковых трав 80% / бобовых трав 20%) для лошадей сенокосно-пастбищного типа. " +
                    "Предназначена для закладки культурных пастбищ и выпаса лошадей, а также для заготовления сена. Отличительные особенности:" +
                    " быстрое отрастание;" +
                    " зимостойкость и засухоустойчивость." +
                    " За счет наличия в составе смеси люцерны изменчивой значительно повышен уровень " +
                    "питательной энергии кормов. Норма высева смеси семян от 35 до 45 кг на гектар для нового" +
                    " пастбища и от 11 до 22 кг на гектар при подсеве",
                    Category = "Травосмеси для лошадей",
                    Price = "290 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 10,
                    Name = "Травосмесь «Износостойкая»",
                    Сomposition = "Люцерна — 10% Райграс пастбищный - 30% Тимофеевка луговая — 30% Фестулолиум — 20% Мятлик луговой — 10%",
                    Description = "Смесь семян многолетних кормовых злаковых трав для лошадей сенокосно-пастбищного типа. " +
                    "Предназначена для закладки культурных пастбищ и выпаса лошадей и других видов скота, а также для заготовления сена." +
                    " Отличительные особенности: быстрое отрастание; зимостойкость и засухоустойчивость; отсутствие в составе травостоя бобовых трав." +
                    " Рекомендуемый период сева — ранней весной (осенью) в прохладную погоду и условиях наибольшего уровня влажности почвы" +
                    ". Норма высева семян от 30 до 40 килограмм на гектар для " +
                    "нового пастбища и от 10 до 20 килограмм на гектар при подсеве",
                    Category = "Травосмеси для лошадей",
                    Price = "245 руб/кг",
                    IsVisible = true
                });
                grassmixturebuilder.HasData(new GrassMixture()
                {
                    Id = 11,
                    Name = "Травосмесь «Элитная» (Рекомендовано)",
                    Сomposition = "Мятлик — 20% Райграс пастбищный — 22% Овсяница тростниковая - 32% Тимофеевка луговая - 10% Овсяница луговая - 10% Клевер белый - 6%",
                    Description = "Смесь семян многолетних кормовых трав для лошадей. " +
                    "Предназначена для закладки культурных пастбищ и выпаса лошадей и других видов скота." +
                    " Отличается разнообразием трав, образует густой травостой, устойчив к вытаптыванию" +
                    ". Норма высева семян от 25 до 40 килограмм на гектар для нового пастбища и от 11 до" +
                    " 22 килограмм на гектар при подсеве",
                    Category = "Травосмеси для лошадей",
                    Price = "300 руб/кг",
                    IsVisible = true
                });


            });


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
