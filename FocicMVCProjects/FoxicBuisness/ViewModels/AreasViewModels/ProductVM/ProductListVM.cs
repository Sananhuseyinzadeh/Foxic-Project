using Foxic.Core.Entities;

namespace Foxic.Buisness.ViewModels.AreasViewModels.ProductVM;

public class ProductlistVM
{
    public string Name { get; set; }
    public int Discount { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }
    public Collection Collection { get; set; }
    public Brand Brand { get; set; }

    public List<Image> Images { get; set; }

    public ProductlistVM()
    {
        Images = new();
    }
}
