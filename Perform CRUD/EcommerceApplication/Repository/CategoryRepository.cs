using EcommerceApplication.Data;
using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApplication.Repository
{
    public class CategoryRepository: ICategory
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CategoryDto> AddCategory(CategoryAddDto CategoryDto)
        {
            var category = new Category();
            category.Name = CategoryDto.Name;
            category.IsActive = CategoryDto.IsActive;
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            var categoryDetail = ShowDetails(category);
            return categoryDetail;
        }
        public async Task<IEnumerable<CategoryDto>> GetAllCategory()
        {
            var categories = await _context.Categories.Where(c => c.IsActive).ToListAsync();
            if(categories == null) return null;
            var categoriesDetail = new List<CategoryDto>();
            foreach (var item in categories)
            {
                categoriesDetail.Add(new CategoryDto
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return categoriesDetail;
        }
        public async Task<CategoryDto> GetCategoryById(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id && c.IsActive);
            if(category == null) return null;
            var categoryDetail = ShowDetails(category);
            return categoryDetail;
        }
        public async Task<CategoryDto> UpdateCategory(CategoryUpdateDto CategoryDto)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == CategoryDto.Id && c.IsActive);
            if (category == null) return null;
            category.Name = CategoryDto.Name;
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            var categoryDetail = ShowDetails(category);
            return categoryDetail;
        }
        public async Task<CategoryDto> DeleteCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id && c.IsActive);
            if (category == null) return null;
            category.IsActive = false;
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            var categoryDetail = ShowDetails(category);
            return categoryDetail;
        }
        public CategoryDto ShowDetails(Category category)
        {
            var categoryDetail = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name
            };
            return categoryDetail;
        }
    }
}
