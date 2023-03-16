
//==============================================================================================================================
//Creates ProductCategory Entity Data Model for the ShepherdPO database ========================================================
//===Implementing Entity Framework linkhttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

namespace ShepherdPOS.Api.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }

        public string? CategoryName { get; set; }
    }
}