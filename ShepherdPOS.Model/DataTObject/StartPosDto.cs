//==============================================================================================================================
//Creates StartPosDto dto Model for the ShepherdPO database ====================================================================
//===Try this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using ShepherdPOS.Models.Classes;

namespace ShepherdPOS.Models.DataTObject
{
    public class StartPosDto
    {
        public ExecuteHandleCartView? Cart { get; set; }

        public AppendPaymentDto? Payment { get; set; }
    }
}
