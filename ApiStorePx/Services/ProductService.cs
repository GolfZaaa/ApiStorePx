using ApiStorePx.Data;
using ApiStorePx.DTOs.Product;
using ApiStorePx.Models;
using ApiStorePx.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ApiStorePx.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.OrderBy(x => x.Name).ToListAsync();
        }

        //sucessfully
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<Product> CreateAsync(CreateProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                SellPrice = dto.SellPrice,
                Stock = 0,
                AvgCost = 0
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> UpdateAsync(int id, UpdateProductDto dto)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return null;
            }
            product.Name = dto.Name;
            product.SellPrice = dto.SellPrice;
            product.UpdateAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return product;
        }


        public async Task<bool> DeleteAsync(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return false;
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();
            return true;
        }

    }
}
