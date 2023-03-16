
//==============================================================================================================================
//Creates SaleProduct Entity Data Model for the ShepherdPO database ============================================================
//===Implementing Entity Framework linkhttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using Duende.IdentityServer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Api.Entities
{
    public class SaleProduct
    {
        public int Id { get; set; }

        public int SaleId { get; set; }

        [Required(ErrorMessage = "Required date and time.")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        public string Barcode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxAmount { get; set; }


        public Sale? Sale { get; set; }
    }
}

