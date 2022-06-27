namespace agrokorm.Models.Products
{
    public class Szr
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string PlaceOfProduction { get; set; }

        public string Manufacturer { get; set; }

        public string Dv { get; set; }

        public string Analog { get; set; }

        public string Consumption { get; set; }

        public string Price { get; set; }

        public bool IsVisible { get;set; }

    }
}
