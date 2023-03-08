namespace ShepherdPOS.Api.Entities
{
    public class SaleProduct
    {
        public int Id { get; set; }

        public int SaleId { get; set; }

        public DateTime Timestamp { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Tax { get; set; }


        public Sale? Sale { get; set; }
    }
}
