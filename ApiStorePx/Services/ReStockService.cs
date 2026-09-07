using ApiStorePx.Data;
using ApiStorePx.DTOs.Stock;
using ApiStorePx.Models;
using ApiStorePx.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ApiStorePx.Services
{
    public class ReStockService : IReStockService
    {
        private readonly DataContext _context;

        public ReStockService(DataContext context)
        {
            _context = context;
        }

        public async Task<Restock> CreateReStock(CreateReStockDto dto)
        {
            if (dto.PackCost <= 0)
                throw new Exception("ราคาต่อแพ็คต้องมากกว่า 0");

            if (dto.UnitsPerPack <= 0)
                throw new Exception("จำนวนชิ้นต่อแพ็คต้องมากกว่า 0");

            if (dto.Packs <= 0)
                throw new Exception("จำนวนแพ็คต้องมากกว่า 0");

            var product = await _context.Products
                .FirstOrDefaultAsync(x => x.Id == dto.ProductId);

            if (product == null)
                throw new Exception("ไม่พบสินค้า");


            var unitCost =
                dto.PackCost / dto.UnitsPerPack;

            var totalUnits =
                dto.UnitsPerPack * dto.Packs;

            var totalCost =
                dto.PackCost * dto.Packs;


            var oldStock = product.Stock;

            var oldAvgCost = product.AvgCost;

            var newStock =
                oldStock + totalUnits;

            decimal newAvgCost;

            if (newStock == 0)
            {
                newAvgCost = unitCost;
            }
            else
            {
                newAvgCost =
                    (
                        (oldStock * oldAvgCost)
                        +
                        (totalUnits * unitCost)
                    )
                    / newStock;
            }


            product.Stock = newStock;

            product.AvgCost = Math.Round(newAvgCost,2);

            product.UpdateAt = DateTime.UtcNow;


            var restock = new Restock
            {
                ProductId = product.Id,

                PackCost = dto.PackCost,

                UnitPerPack =
                    dto.UnitsPerPack,

                Packs = dto.Packs,

                UnitCost =
                    Math.Round(unitCost, 2),

                TotalUnits =
                    totalUnits,

                TotalCost =
                    totalCost,

                CreatedAt = DateTime.UtcNow
            };

            _context.Restocks.Add(restock);

            await _context.SaveChangesAsync();

            return restock;
        }
    }
}
