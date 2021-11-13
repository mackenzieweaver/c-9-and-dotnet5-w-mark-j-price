using Piranha.AttributeBuilder;
using Piranha.Models;

namespace NorthwindCms.Models
{
    [PageType(Title = "Catalog Page", UseBlocks = false)]
    [ContentTypeRoute(Title = "Default", Route = "/catalog")]
    public class CatalogPage : Page<CatalogPage>
    {        
    }
}
