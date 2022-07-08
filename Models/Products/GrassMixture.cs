namespace agrokorm.Models.Products
{
    public class GrassMixture
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Сomposition { get; set; }

        public string Category { get; set; }

        public string? Description { get; set; }

        public string Price { get; set; }

        public bool IsVisible { get; set; }
    }
}
