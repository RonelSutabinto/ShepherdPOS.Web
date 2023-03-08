using ShepherdPOS.Models.Classes;

namespace ShepherdPOS.Models.DataTObject
{
    public class StartPosDto
    {
        public ExecuteHandleCartView? Cart { get; set; }

        public AppendPaymentDto? Payment { get; set; }
    }
}
