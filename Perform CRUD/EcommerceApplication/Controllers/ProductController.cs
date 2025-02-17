using EcommerceApplication.IRepository;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        public ILogger _logger;
        public ProductController(IProduct product, ILogger<ProductController> logger)
        {
            _product = product;
            _logger = logger;
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _product.GetAllProduct();
            if (products == null) throw new FileNotFoundException("There is no product available");
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
            var product = _product.DeleteProduct(id);
            if(product == null) throw new FileNotFoundException($"No Product Found by id = {id}");
            return Ok(product);
        }
    }
}
