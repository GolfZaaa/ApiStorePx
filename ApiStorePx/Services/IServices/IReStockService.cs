using ApiStorePx.DTOs.Stock;
using ApiStorePx.Models;
using ApiStorePx.Response;

namespace ApiStorePx.Services.IServices
{
    public interface IReStockService
    {
        Task<ReStockResponseDto> CreateReStock(CreateReStockDto dto);
    }
}
