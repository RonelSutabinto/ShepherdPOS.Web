//==============================================================================================================================
//Creates AppendStockDto dto Model for the ShepherdPO database =================================================================
//===ITry this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTObject
{
    public class AppendStockDto
    {
        [Required]
        public int ProductId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Quantity must be not less than to one.")]
        public int Quantity { get; set; }
    }
}
