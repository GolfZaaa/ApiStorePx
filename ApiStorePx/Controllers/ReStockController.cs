using ApiStorePx.DTOs.Stock;
using ApiStorePx.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiStorePx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReStockController : ControllerBase
    {
        private readonly IReStockService _reStockService;

        public ReStockController(IReStockService reStockService)
        {
            _reStockService = reStockService;
        }

        [HttpPost("CreateReStockDto")]
        public async Task<IActionResult> CreateReStock(CreateReStockDto dto)
        {
            var restock = await _reStockService.CreateReStock(dto);

            return Ok(restock);
        }
    }
}
