using ShepherdPOS.Models.ViewModels;

namespace ShepherdPOS.Models.Classes
{
    public class ExecuteHandleCartView
    {
        public List<CartRow> Rows { get; set; }
        public decimal PostTAmnt { get; set; }

        public ExecuteHandleCartView()
        {
            Rows = new();
            DiscountAmount = 0;
        }

        public int Quantity { get { return Rows.Sum(_row => _row.Quantity); } }
        public decimal TaxAmount { get { return Rows.Sum(_row => _row.TaxAmount); } }
        public decimal TotalAmount { get { return Rows.Sum(_row => _row.TotalAmount); } }
        public decimal DiscountAmount { get; set; }
        public decimal DiscounttoCart { get { return TotalAmount * DiscountAmount / 100; } }

        public decimal AmountDue { get {
                if (DiscountAmount == 0)
                {
                    PostTAmnt = TotalAmount;
                    return TotalAmount;
                }

                else
                {
                    PostTAmnt = TotalAmount - TotalAmount * (DiscountAmount / 100);
                    return PostTAmnt;
                }

                    
            }
        }

        public void AppendToCart(SelectProductView product)
        {
            var existingRow = GetCartRow(product.Barcode);
            if (existingRow != null)
                existingRow.Quantity++;
            else
                Rows.Add(new CartRow{ Product = product, Quantity = 1 });
            
        }

        public int ProductQuantity(string productCode)
        {
            var existingRow = GetCartRow(productCode);
            return existingRow == null ? 0 : existingRow.Quantity;
        }

        private CartRow? GetCartRow(string productCode)
        {
            return Rows.FirstOrDefault(_row => _row.Product.Barcode == productCode);
        }

        public void DeleteFromCart(SelectProductView product)
        {
            var existingRow = GetCartRow(product.Barcode);
            if (existingRow!.Quantity == 1)
                Rows.Remove(existingRow);
            else
                existingRow.Quantity--;
        }

       
        
    }

    public class CartRow
    {
        public decimal TotalAmount { get { return Product.SalePrice * Quantity; } }
        public int Quantity { get; set; }
        public decimal TaxAmount { get { return Product.TaxAmount * Quantity; } }
        public SelectProductView Product { get; set; }
    }
}
