//==============================================================================================================================
//Creates Stock Entity Data Model for the ShepherdPO database ==================================================================
//===Implementing Entity Framework linkhttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using Duende.IdentityServer.Models;
using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Api.Entities
{
    public class Stock
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        [Required(ErrorMessage = "Required date and time.")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        public Product? Product { get; set; }
    }
}