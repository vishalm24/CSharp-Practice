using EcommerceApplication.IRepository;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductController(IProduct product, ILogger<ProductController> logger)
        {
            _product = product;
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _product.GetAllProduct();
            if (products == null) return NotFound("There is no product available");
            return Ok(products);
        }

        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _product.GetProductById(id);
            if(product == null) return NotFound("Product not found");
            return Ok(product);
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct(ProductAddDto productDto)
        {

            var product = await _product.AddProduct(productDto);
            if (product == null) return BadRequest("Product already exists");
            return Ok(product);
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto productDto)
        {
            var product = await _product.UpdateProduct(productDto);
            if (product == null) return BadRequest("Product already exists");
            return Ok(product);
        }

        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = _product.DeleteProduct(id);
            if(product == null) return NotFound("Product not found");
            return Ok(product);
        }
    }
}
