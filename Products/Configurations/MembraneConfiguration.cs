﻿using System.ComponentModel.DataAnnotations;

namespace agrokorm.Models.Products.Configurations
{
    public class MembraneConfiguration : IBaseConfiguration
    {
 
        public int Id { get; set; }

        public string Color { get; set; }

        public int Width { get; set; }

        public int Length { get; set; }

        public string Price { get; set; }

        public string Type { get; set; }

        public int MembraneId { get; set; } 
    }
}
