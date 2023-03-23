//==============================================================================================================================
//Creates ExecuteHandleCartView Model that contain fields that represent to the razor view pos page  ===========================
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=================
//==============================================================================================================================


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

        public decimal DiscountAmount { get; set; }
        public decimal DiscounttoCart { get { return TotalAmount * DiscountAmount / 100; } }

        public int Quantity { get { return Rows.Sum(_row => _row.Quantity); } }
        public decimal TaxAmount { get { return Rows.Sum(_row => _row.TaxAmount); } }
        public decimal TotalAmount { get { return Rows.Sum(_row => _row.TotalAmount); } }
        public void AppendToCart(SelectProductView product)
        {
            var inRow = GetPosCartRow(product.Barcode);
            if (inRow != null)
                inRow.Quantity = inRow.Quantity + 1;
            else
                Rows.Add(new CartRow { Product = product, Quantity = 1 });

        }

        public int ProductQuantity(string productCode)
        {
            var inRow = GetPosCartRow(productCode);
            int resultQty = 0;
            
            if (inRow != null )
               resultQty =  GetPosCartRow(productCode).Quantity; 
            
            return resultQty;
        }

        private CartRow? GetPosCartRow(string productCode) {return Rows.FirstOrDefault(_row => _row.Product.Barcode == productCode);}

        public void DeleteFromCart(SelectProductView product)
        {
            var inRow = GetPosCartRow(product.Barcode);
            if (inRow!.Quantity == 1)
                Rows.Remove(GetPosCartRow(product.Barcode));
            else
                inRow.Quantity = GetPosCartRow(product.Barcode).Quantity - 1;
        }

        public decimal AmountDue
        {
            get
            {
                if (DiscountAmount == 0)
                {
                    PostTAmnt = TotalAmount + TaxAmount;
                    return PostTAmnt;
                }

                else
                {
                    PostTAmnt = TotalAmount -( TotalAmount * (DiscountAmount / 100)+ TaxAmount);
                    return PostTAmnt;
                }


            }
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
