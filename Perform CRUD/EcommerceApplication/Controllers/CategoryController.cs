using EcommerceApplication.IRepository;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategory()
        {
            var categories = await _category.GetAllCategory();
            if (categories == null) throw new FileNotFoundException("There is no category available.");
            return Ok(categories);
        }
        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _category.GetCategoryById(id);
            if (category == null) throw new FileNotFoundException($"No Category Found by id = {id}");
            return Ok(category);
        }
        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(CategoryAddDto categoryDto)
        {
            if (!ModelState.IsValid) throw new ApplicationException("Category details are invalid.");
            var category = await _category.AddCategory(categoryDto);
            if(category == null) throw new ApplicationException("Category details are invalid.");
            return Ok(category);
        }
        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory(CategoryUpdateDto categoryDto)
        {
            var category = await _category.UpdateCategory(categoryDto);
            if(category == null) throw new ApplicationException("Category details are invalid.");
            return Ok(category);
        }
        [HttpDelete("RemoveCategory")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _category.DeleteCategory(id);
            if(category == null) throw new FileNotFoundException($"No Category Found by id = {id}");
            return Ok(category);
        }
    }
}
