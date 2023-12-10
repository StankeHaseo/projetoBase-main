using HelperStockBeta.Application.DTOs;

namespace HelperStockBeta.Application.Interfaces{

    public interface IProductService
    {
        
        Task<IEnumerable<ProductDTO>> GetProductAsync();
        Task<ProductDTO> GetProductByIdAsync(ProductDTO productDTO);
        Task <ProductDTO> AddProductByIdAsync(ProductDTO productDTO);
        Task <ProductDTO> UpdateProductAsync(ProductDTO productDTO);
        Task <ProductDTO> DeleteProductAsync(int id);
        
    }
}