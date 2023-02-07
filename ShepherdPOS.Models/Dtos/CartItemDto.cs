using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Models.Dtos
{
    //Cart Data transfer object====
	public class CartItemDto
	{
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CartId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductImageURL { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

        public int Qty { get; set; }
        
    }
}

