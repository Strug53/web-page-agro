﻿using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;

namespace agrokorm.Models.Form
{
    public class FormViewModel
    {
        public SunflowerSeed seed { get; set; }
        public Membrane membrane { get; set; }
        public MembraneConfiguration membraneConfiguration { get; set; }
        public Szr szr { get; set; }
        public PriceChangingFormModel priceChangingFormModel { get; set; }
        public TitleAndDescriptionChangingFormModel titleAndDescriptionChangingFormModel { get; set; }

        public SpringSeed springSeed { get; set; }

        public FormViewModel()
        {
            seed = new SunflowerSeed();
            membrane = new Membrane();
            membraneConfiguration = new MembraneConfiguration();
            priceChangingFormModel = new PriceChangingFormModel();
            titleAndDescriptionChangingFormModel = new TitleAndDescriptionChangingFormModel();
            szr = new Szr();
            springSeed = new SpringSeed();
    }
}
}
