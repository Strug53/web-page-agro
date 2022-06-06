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

        public DbSet<MembraneConfiguration> MembraneConfigurations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);



            //Membrane
            modelbuilder.Entity<Membrane>().HasData(new Membrane
            {
                Id = 1,
                Name = "Плёнка Silоfolie strong",
                Color = "Черная",
                Width = 10,
                Lenght = 50,
                Type = "type 150",
                Price = 10092,
                IsVisible = true,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a " +
                "galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap " +
                "into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
                "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = CategoryEnum.Membrance,
                membraneConfigurations = null
            }) ;

            modelbuilder.Entity<Membrane>().HasData(new Membrane
            {
                Id = 2,
                Name = "Плёнка Silоfolie",
                Color = "Черная",
                Width = 10,
                Lenght = 50,
                Type = "type 150",
                Price = 12414,
                IsVisible = true,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a " +
                "galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap " +
                "into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
                "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = CategoryEnum.Membrance,
                membraneConfigurations = null
            });


            //Membrane Configuration

            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 1,
                Color = "Черный",
                Width = 14,
                Height = 50,
                Type = "type 150",
                Price = 14370,
                MembraneId = 1
            });
            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 2,
                Color = "Черный",
                Width = 12,
                Height = 50,
                Type = "type 150",
                Price = 13014,
                MembraneId = 2
            });
            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 3,
                Color = "Черный",
                Width = 14,
                Height = 50,
                Type = "type 150",
                Price = 15186,
                MembraneId = 2
            });
            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 4,
                Color = "Черный",
                Width = 16,
                Height = 50,
                Type = "type 150",
                Price = 17922,
                MembraneId = 2
            });
            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 5,
                Color = "Черный",
                Width = 18,
                Height = 50,
                Type = "type 150",
                Price = 22692,
                MembraneId = 2
            });
            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 6,
                Color = "Черно-белый",
                Width = 14,
                Height = 50,
                Type = "type 150",
                Price = 17460,
                MembraneId = 2
            });
            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 7,
                Color = "Черно-белый",
                Width = 16,
                Height = 50,
                Type = "type 150",
                Price = 21540,
                MembraneId = 2
            });
            modelbuilder.Entity<MembraneConfiguration>().HasData(new MembraneConfiguration
            {
                Id = 8,
                Color = "Черно-белый",
                Width = 18,
                Height = 50,
                Type = "type 150",
                Price = 29268,
                MembraneId = 2
            });





        }

       
    }
}
