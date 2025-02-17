using EcommerceApplication.Data;
using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApplication.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ProductDto> AddProduct(ProductAddDto productDto)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.CategoryId == productDto.CategoryId 
                                                                && p.Name == productDto.Name);
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == productDto.CategoryId && c.IsActive);
            if (product != null || category == null) return null;
            var productDetail = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId,
                IsActive = productDto.IsActive
            };
            _context.Products.Add(productDetail);
            await _context.SaveChangesAsync();
            var productDtoDetail = await showDetails(productDetail);
            return productDtoDetail;
        }
        //Can't apply  await Async on DeleteProduct find reason and rectify it.
        public async Task<ProductDto> DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id && p.IsActive);
            if (product == null) return null;
            product.IsActive = false;
            _context.Products.Update(product);
            _context.SaveChanges();
            await DeleteOrder(id);
            _context.SaveChanges();
            var productDtoDetail = await showDetails(product);
            return productDtoDetail;
        }
        public async Task DeleteOrder(int id)
        {
            var orders = _context.Orders.ToList().FindAll(o => o.ProductId == id);
            foreach(var item in orders)
            {
                var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == item.Id);
                order.IsActive = false;
                _context.Orders.Update(order);
            }
        }
        public async Task<IEnumerable<ProductDto>> GetAllProduct()
        {
            var products = await _context.Products
                           .Where(p => p.IsActive)
                           .Include(p => p.Category)
                           .Select(p => new ProductDto
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Price = p.Price,
                               CategoryName = p.Category.Name
                           }).ToListAsync();
            return products;
        }
        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
            if (product == null) return null;
            var productDtoDetail = await showDetails(product);
            return productDtoDetail;
        }
        public async Task<ProductDto> UpdateProduct(ProductUpdateDto productDto)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == productDto.Id && p.IsActive);
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == productDto.CategoryId && c.IsActive);
            if (product == null || category == null) return null;
            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.CategoryId = productDto.CategoryId;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            var productDtoDetail = await showDetails(product);
            return productDtoDetail;
        }
        public async Task<ProductDto> showDetails(Product product)
        {
            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                CategoryName = _context.Categories.FirstOrDefault(c => c.Id == product.CategoryId).Name
            };
            return productDto;
        }
    }
}
