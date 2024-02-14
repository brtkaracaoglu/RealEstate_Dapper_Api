using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();



        void CreateProduct(CreateProductDto createProductDto);
        void DeleteProduct(int id);
        void UpdateProduct(UpdateProductDto updateProductDto);
        Task<GetByIDProductDto> GetProduct(int id);

    }
}
