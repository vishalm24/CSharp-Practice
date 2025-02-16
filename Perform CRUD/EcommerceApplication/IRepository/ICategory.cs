using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;

namespace EcommerceApplication.IRepository
{
    public interface ICategory
    {
        public Task<CategoryDto> GetCategoryById(int id);
        public Task<IEnumerable<CategoryDto>> GetAllCategory();
        public Task<CategoryDto> AddCategory(CategoryAddDto CategoryDto);
        public Task<CategoryDto> UpdateCategory(CategoryUpdateDto CategoryDto);
        public Task<CategoryDto> DeleteCategory(int id);
    }
}
