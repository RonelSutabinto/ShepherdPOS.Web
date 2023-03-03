using System;
namespace ShepherdPOS.Api.Entities.CartItem
{
	public class CartItem
	{
        public int Id { get; set; }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }
    }
}

