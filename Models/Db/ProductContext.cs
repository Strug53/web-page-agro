﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Seed> Seeds { get; set; }
        public DbSet<MembraneConfiguration> MembraneConfigurations { get; set; }


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
                    membraneConfigurations = null
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
                    membraneConfigurations = null
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
            modelbuilder.Entity<Seed>(seedbuilder =>
            {
                seedbuilder.HasData(new Seed()
                {
                    Id = 1,
                    Name = "НС-Х-95 Элит",
                    PlaceOfProduction = "Россия",
                    Price = "10733",
                    IsVisible = true
                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 2,
                    Name = "НС-Х-95 стандарт",
                    PlaceOfProduction = "Россия",
                    Price = "8401",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 3,
                    Name = "НС-Х-26752 элит",
                    PlaceOfProduction = "Россия",
                    Price = "13647",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 4,
                    Name = "НС-Х-26752 стандарт",
                    PlaceOfProduction = "Россия",
                    Price = "9419",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 5,
                    Name = "НС-Х-496 элит",
                    PlaceOfProduction = "Россия",
                    Price = "14413",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 6,
                    Name = "НС-Х-496 стандарт",
                    PlaceOfProduction = "Россия",
                    Price = "9660",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 7,
                    Name = "НС-Х-498 элит",
                    PlaceOfProduction = "Россия",
                    Price = "14413",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 8,
                    Name = "НС-Х-498 стандарт",
                    PlaceOfProduction = "Россия",
                    Price = "9660",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 9,
                    Name = "НС-Х-8003 элит",
                    PlaceOfProduction = "Россия",
                    Price = "14413",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 10,
                    Name = "НС-Х-8003 стандарт",
                    PlaceOfProduction = "Россия",
                    Price = "9660",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 11,
                    Name = "НС-Х-8003 стандарт 1 мелк",
                    PlaceOfProduction = "Россия",
                    Price = "5660",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 12,
                    Name = "Римисол элит",
                    PlaceOfProduction = "Россия",
                    Price = "13647",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 13,
                    Name = "Римисол стандарт",
                    PlaceOfProduction = "Россия",
                    Price = "9507",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 14,
                    Name = "Римисол стандарт 1 мелк",
                    PlaceOfProduction = "Россия",
                    Price = "5660",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 15,
                    Name = "НС-Х-7806 элит",
                    PlaceOfProduction = "Россия",
                    Price = "13647",
                    IsVisible = true

                });
                seedbuilder.HasData(new Seed()
                {
                    Id = 16,
                    Name = "НС-Х-7806 стандарт",
                    PlaceOfProduction = "Россия",
                    Price = "9507",
                    IsVisible = true

                });

                seedbuilder.ToTable("Seeds").HasKey(x => x.Id);

                seedbuilder.Property(x => x.Id).ValueGeneratedOnAdd();

            }
            );
        }

       
    }
}
