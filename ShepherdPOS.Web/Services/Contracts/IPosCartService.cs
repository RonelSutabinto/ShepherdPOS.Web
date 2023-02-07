using ShepherdPOS.Models.Dtos;

namespace ShepherdPOS.Web.Services.Contracts
{
	public interface IPosCartService
	{
        Task<List<CartItemDto>> GetItems(int userId);

        Task<CartItemDto> AddItem(CartItemToAddDto cartItemToAddDto);

        Task<CartItemDto> DeleteItem(int id);

        Task<CartItemDto> UpdateQty(CartItemQtyUpdateDto cartItemQtyUpdateDto);

        event Action<int> OnPosCartChanged;

        void RaiseEventOnPosCartChanged(int totalQty);
    }
}

