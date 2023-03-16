//==============================================================================================================================
//Creates PurchaseDiscountDto dto Model for the ShepherdPO database ============================================================
//===Try this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTObject
{
    public class PurchaseDiscountDto
    {
        [Required]
        [Range(1, 99)]
        public decimal DiscountAmount { get; set; }
    }
}
