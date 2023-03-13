namespace ShepherdPOS.Api.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}