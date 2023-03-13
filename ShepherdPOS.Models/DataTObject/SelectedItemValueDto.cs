namespace ShepherdPOS.Models.DataTObject
{
    public class SelectedItemValueDto
    {
        public string Text { get; set; } = string.Empty;

        [Required]
        public int Value { get; set; }
    }
}
