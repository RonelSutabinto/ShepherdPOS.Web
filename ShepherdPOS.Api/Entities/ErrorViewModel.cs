//==============================================================================================================================
//Creates ErrorViewModel Model that contain meassage that represent to the razor view product  =================================
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=================
//==============================================================================================================================

namespace ShepherdPOS.Api.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

