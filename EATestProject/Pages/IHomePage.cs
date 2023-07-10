namespace EATestProject.Pages
{
    public interface IHomePage
    {
        //IWebElement LnkCreate { get; }
        //IWebElement LnkProduct { get; }

        void CreateProduct();

        void PerformClickOnSpecialValue(string name, string operation);
        // void Open();
    }
}