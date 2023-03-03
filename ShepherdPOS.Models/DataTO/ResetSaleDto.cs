using ShepherdPOS.Models.ViewModel;

namespace ShepherdPOS.Models.DataTO
{
    public class ResetSaleDto
    {
        public PosCart? PosCart { get; set; }

        public PaymentDto? Payment { get; set; }
    }
}
