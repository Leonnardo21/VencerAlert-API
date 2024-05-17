using Microsoft.EntityFrameworkCore;
using VencerAlert.Domain.Abstractions;
using VencerAlert.Domain.Entities;
using VencerAlert.Infrastructure.Context;

namespace VencerAlert.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            if (_context is not null  && _context.Products is not null)
            {
                var products = await _context.Products.ToListAsync();
                await _context.SaveChangesAsync();
                return products;
            }
            else
            {
                return new List<Product>();
            }
        }

        public async Task<Product?> GetProductById(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product is null)
                throw new InvalidOperationException($"Produto com ID {id} não encontrado...");

            return product;
        }

        public async Task<Product> AddProduct(Product product)
        {
            if(_context is not null && product is not null && _context.Products is not null)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return product;
            }else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }
        public async Task UpdateProduct(Product product)
        {
            if(product is not null)
            {
                _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }

        public async Task DeleteProduct(int id)
        {
            var product = await GetProductById(id);

            if(product is not null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }
    }
}
