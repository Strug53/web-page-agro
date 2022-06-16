using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;

namespace agrokorm.Models.Form
{
    public class FormViewModel
    {
        public Seed seed { get; set; }
        public Membrane membrane { get; set; }
        public MembraneConfiguration membraneConfiguration { get; set; }
        public PriceChangingFormModel priceChangingFormModel { get; set; }
        public TitleAndDescriptionChangingFormModel titleAndDescriptionChangingFormModel { get; set; }

        public FormViewModel()
        {
            seed = new Seed();
            membrane = new Membrane();
            membraneConfiguration = new MembraneConfiguration();
            priceChangingFormModel = new PriceChangingFormModel();
            titleAndDescriptionChangingFormModel = new TitleAndDescriptionChangingFormModel();

    }
}
}
