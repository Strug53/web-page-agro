using agrokorm.Models.Products;

namespace agrokorm.Repository.Interfaces.SeedsInterfaces
{
    public interface ISeedRepository : ISpringSeedRepository, ISunflowerRepository, ILegumesRepository, IGrassSeedRepository 
    {
        
    }
}
