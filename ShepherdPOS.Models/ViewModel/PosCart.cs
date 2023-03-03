namespace ShepherdPOS.Models.ViewModel
{
    public class PosCart
    {
        public List<CartRow> Rows { get; set; }

        public PosCart()
        {
            Rows = new();
            DiscountAmount = 0;
        }

        public int Quantity
        {
            get
            {
                return Rows.Sum(l => l.Quantity);
            }
        }

        public decimal Tax
        {
            get
            {
                return Rows.Sum(l => l.Tax);
            }
        }

        public decimal Total
        {
            get
            {
                return Rows.Sum(l => l.Total);
            }
        }

        public decimal DiscountAmount { get; set; }

        public decimal Due
        {
            get
            {
                if (DiscountAmount == 0)
                    return Total;
                else
                    return Total - Total * DiscountAmount / 100;
            }
        }

        public void AddToCart(ProductView product)
        {
            var existingLine = GetCartRow(product.Code);

            if (existingLine != null)
                existingLine.Quantity++;
            else
            {
                Rows.Add(new CartRow
                {
                    Product = product,
                    Quantity = 1
                });
            }
        }

        public void RemoveFromCart(ProductView product)
        {
            var existingLine = GetCartRow(product.Code);

            if (existingLine!.Quantity == 1)
                Rows.Remove(existingLine);
            else
            {
                existingLine.Quantity--;
            }
        }

        public int ProductQuantity(string productCode)
        {
            var existingLine = GetCartRow(productCode);

            return existingLine == null ? 0 : existingLine.Quantity;
        }

        private CartRow? GetCartRow(string productCode)
        {
            return Rows.FirstOrDefault(l => l.Product.Code == productCode);
        }
    }

    public class CartRow
    {
        public ProductView Product { get; set; }

        public int Quantity { get; set; }

        public decimal Total
        {
            get
            {
                return Product.Price * Quantity;
            }
        }

        public decimal Tax
        {
            get
            {
                return Product.Tax * Quantity;
            }
        }
    }
}
