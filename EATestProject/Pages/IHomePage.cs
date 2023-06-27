namespace EATestProject.Pages
{
    public interface IHomePage
    {
        //IWebElement LnkCreate { get; }
        //IWebElement LnkProduct { get; }

        void CreateProduct();

        void PerformClickOnDetails(string name, string operation);
        // void Open();
    }
}