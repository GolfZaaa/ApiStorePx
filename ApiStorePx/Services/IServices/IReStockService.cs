using ApiStorePx.DTOs.Stock;
using ApiStorePx.Models;

namespace ApiStorePx.Services.IServices
{
    public interface IReStockService
    {
        Task<Restock> CreateReStock(CreateReStockDto dto);
    }
}
