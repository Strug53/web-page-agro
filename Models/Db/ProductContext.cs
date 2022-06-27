using Microsoft.EntityFrameworkCore;
using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;
using agrokorm.Models.Enum;

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
                    Category = CategoryEnum.Membrance,
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
                    Category = CategoryEnum.Membrance,
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
        }

       
    }
}
