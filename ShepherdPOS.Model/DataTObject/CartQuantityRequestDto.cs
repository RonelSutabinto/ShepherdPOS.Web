//==============================================================================================================================
//Creates CartQuantityRequestDto dto Model for the ShepherdPO database =========================================================
//===Try this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Models.DataTObject
{
    public class CartQuantityRequestDto
    {

        public int ProductId { get; set; }

        public int CartQuantity { get; set; }
    }
}