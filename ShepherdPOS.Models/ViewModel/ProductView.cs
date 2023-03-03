namespace ShepherdPOS.Models.ViewModel
{
    public class ProductView
    {
        public int Id { get; set; }

        public int ProductCategoryId { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Tax { get; set; }
    }
}