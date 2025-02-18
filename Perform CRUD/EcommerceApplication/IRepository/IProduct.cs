using EcommerceApplication.Model.Dto;

namespace EcommerceApplication.IRepository
{
    public interface IProduct
    {
        public Task<IEnumerable<ProductDto>> GetAllProduct();
        public Task<ProductDto> GetProductById(int id);
        public Task<ProductDto> AddProduct(ProductAddDto product);
        public Task<ProductDto> UpdateProduct(ProductUpdateDto product);
        public Task<ProductDto> DeleteProduct(int id);
        public Task<IEnumerable<ProductDto>> CategoryFilter(int id);
    }
}
