﻿namespace agrokorm.Models.Products.Configurations
{
    public interface IBaseConfiguration
    {
        public int Id { get; set; }
        
        public string Price { get; set; }
    }
}
