namespace ShepherdPOS.Models.ViewModels
{
    public class ProductGroupView
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; } 
    }
}
