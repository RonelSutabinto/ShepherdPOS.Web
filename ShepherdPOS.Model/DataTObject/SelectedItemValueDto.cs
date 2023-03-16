//==============================================================================================================================
//Creates PurchaseDiscountDto dto Model for the ShepherdPO database ============================================================
//===Try this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================
namespace ShepherdPOS.Models.DataTObject
{
    public class SelectedItemValueDto
    {
        public string Text { get; set; } = string.Empty;

        public int Value { get; set; }
    }
}
