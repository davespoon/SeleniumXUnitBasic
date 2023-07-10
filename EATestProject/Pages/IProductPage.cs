using EATestProject.Model;

namespace EATestProject.Pages
{
    public interface IProductPage
    {
        void EnterProductDetails(Product product);
        Product GetProductDetails();
    }
}