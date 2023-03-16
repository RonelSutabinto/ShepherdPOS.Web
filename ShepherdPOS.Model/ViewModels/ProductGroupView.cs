//==============================================================================================================================
//Creates ProductGroupView Model that contain fields that represent to the razor view product category =========================
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=============
//==============================================================================================================================

namespace ShepherdPOS.Models.ViewModels
{
    public class ProductGroupView
    {
        public int Id { get; set; }

        public string? CategoryName { get; set; }
    }
}
