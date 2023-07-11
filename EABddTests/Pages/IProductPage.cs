using EABddTests.Model;

namespace EABddTests.Pages
{
    public interface IProductPage
    {
        void EnterProductDetails(Product product);
        Product GetProductDetails();
    }
}