using EcommerceApplication.Cache;
using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using LazyCache;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        private readonly ICacheProvider _cacheProvider;
        public ProductController(IProduct product, ICacheProvider cacheProvider)
        {
            _product = product;
            _cacheProvider =  cacheProvider;
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProduct()
        {
            if(!_cacheProvider.TryGetValue(CacheKeys.Product, out IEnumerable<ProductDto> products))
            {
                products = await _product.GetAllProduct();
                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(1),
                    //SlidingExpiration = TimeSpan.FromMinutes(1),
                    Size = 1024
                };
                _cacheProvider.Set(CacheKeys.Product, products, cacheEntryOptions);
            }
            return Ok(products);
        }

        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _product.GetProductById(id);
            if (product == null) throw new FileNotFoundException($"No Product Found by id = {id}");
            return Ok(product);
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct(ProductAddDto productDto)
        {

            var product = await _product.AddProduct(productDto);
            if (product == null) throw new ApplicationException("Product details are invalid.");
            return Ok(product);
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto productDto)
        {
            var product = await _product.UpdateProduct(productDto);
            if (product == null) throw new ApplicationException("Product details are invalid.");
            return Ok(product);
        }

        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _product.DeleteProduct(id);
            if(product == null) throw new FileNotFoundException($"No Product Found by id = {id}");
            return Ok(product);
        }

        [HttpGet("GetProductsByCategoryId")]
        public async Task<IActionResult> CategoryFilter(int id)
        {
            var products = await _product.CategoryFilter(id);
            if (products.IsNullOrEmpty()) throw new FileNotFoundException($"No Porducts Found by Category id = {id}");
            return Ok(products);
        }
        [HttpGet("GetProductsByPage")]
        public async Task<IActionResult> GetProductsByPage(int page)
        {
            var products = await _product.GetProductsByPage(page);
            if (products.IsNullOrEmpty()) throw new FileNotFoundException($"No Porducts found on page = {page}");
            return Ok(products);
        }
    }
}
